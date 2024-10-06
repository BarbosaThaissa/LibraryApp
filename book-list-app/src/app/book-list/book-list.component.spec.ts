import { ComponentFixture, TestBed } from '@angular/core/testing';
import { BookListComponent } from './book-list.component';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { BookService } from '../book.service';
import { of } from 'rxjs';
import { Book } from '../book';

describe('BookListComponent', () => {
  let component: BookListComponent;
  let fixture: ComponentFixture<BookListComponent>;
  let bookService: BookService;
  let httpTestingController: HttpTestingController;
  let mockBooks: Book[];

  beforeEach(async () => {
    mockBooks = [
      {
        id: 1,
        title: '1984',
        author: 'George Orwell',
        description: 'Dystopian novel',
      },
      {
        id: 2,
        title: 'To Kill a Mockingbird',
        author: 'Harper Lee',
        description: 'Classic of modern American literature',
      },
    ];

    await TestBed.configureTestingModule({
      imports: [HttpClientTestingModule, BookListComponent], // Importar o componente standalone
      providers: [BookService],
    }).compileComponents();

    fixture = TestBed.createComponent(BookListComponent);
    component = fixture.componentInstance;
    bookService = TestBed.inject(BookService);
    httpTestingController = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpTestingController.verify();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should call getBooks and return list of books', () => {
    spyOn(bookService, 'getBooks').and.returnValue(of(mockBooks));
    component.getBooks();
    expect(component.books.length).toBe(2);
    expect(component.books).toEqual(mockBooks);
  });

  it('should render book titles in the template', () => {
    spyOn(bookService, 'getBooks').and.returnValue(of(mockBooks));
    component.getBooks();
    fixture.detectChanges();

    const compiled = fixture.nativeElement as HTMLElement;
    const bookTitles = compiled.querySelectorAll('.card-title');
    expect(bookTitles.length).toBe(2);
    expect(bookTitles[0].textContent).toContain('1984');
    expect(bookTitles[1].textContent).toContain('To Kill a Mockingbird');
  });
});
