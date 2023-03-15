export class Restaurant {
    public RestaurantId: number;
    public RestaurantName: string;
    public Grade: string;
    public Street: string;
    public City: string;
    public State: string;

    constructor(restaurantId: number, restaurantName: string, grade: string, street: string, city: string, state: string) {
        this.RestaurantId = restaurantId;
        this.RestaurantName = restaurantName;
        this.Grade = grade;
        this.Street = street;
        this.City = city;
        this.State = state;
    }
}
