export interface Product {
  id: number;
  name: string;
  price: number;
  image: string;
  isActive: boolean;
  basketPositions: BasketPosition[] | null;
  orderPositions: OrderPosition[] | null;
}
