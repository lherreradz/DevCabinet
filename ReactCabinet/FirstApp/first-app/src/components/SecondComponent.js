import React, {Component} from "react";

class SecondComponent extends Component{
    render(){
        let recipe = {
            name : "Pizza",
            ingredients : ['Tomatoes', 'Cheese', 'Oregano'],
            calories : 300
        }


        return(
            <div>
                <h1>Recipe: {recipe.name}</h1>
                <h3>Calories: {recipe.calories}</h3>
                <h3>Ingredients</h3>
                <ul>
                    {
                        recipe.ingredients.map((ingredient, i) => {
                            return <li key={i}>{ingredient}</li>
                        })
                    }
                </ul>
            </div>
        )
    }
}

export default SecondComponent;