using System.Collections.Generic;

namespace EF_LINQ_OPS.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class Ingredient
    {
        public string display_singular { get; set; }
        public string display_plural { get; set; }
        public int? created_at { get; set; }
        public int? updated_at { get; set; }
        public int? id { get; set; }
        public string name { get; set; }
    }

    public class Unit
    {
        public string system { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string display_singular { get; set; }
        public string display_plural { get; set; }
    }

    public class Measurement
    {
        public Unit unit { get; set; }
        public int? id { get; set; }
        public string quantity { get; set; }
    }

    public class Component
    {
        public Ingredient ingredient { get; set; }
        public int? id { get; set; }
        public string raw_text { get; set; }
        public string extra_comment { get; set; }
        public int? position { get; set; }
        public List<Measurement> measurements { get; set; }
    }

    public class Section
    {
        public object name { get; set; }
        public int? position { get; set; }
        public List<Component> components { get; set; }
    }

    public class UserRatings
    {
        public int? count_positive { get; set; } = 999;
        public int? count_negative { get; set; } = 999;
        public double? score { get; set; } = 99.99;
    }

    public class Rendition
    {
        public int? duration { get; set; }
        public int? file_size { get; set; }
        public int? minimum_bit_rate { get; set; }
        public string content_type { get; set; }
        public string url { get; set; }
        public string poster_url { get; set; }
        public string name { get; set; }
        public int? height { get; set; }
        public int? width { get; set; }
        public int? bit_rate { get; set; }
        public int? maximum_bit_rate { get; set; }
        public string aspect { get; set; }
        public string container { get; set; }
    }

    public class Instruction
    {
        public string display_text { get; set; }
        public int? position { get; set; }
        public int? start_time { get; set; }
        public int? end_time { get; set; }
        public object temperature { get; set; }
        public object appliance { get; set; }
        public int? id { get; set; }
    }

    public class Credit
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Nutrition
    {
        public int? protein { get; set; }
        public int? sugar { get; set; }
        public int? fiber { get; set; }
        public System.DateTime updated_at { get; set; }
        public int? calories { get; set; }
        public int? carbohydrates { get; set; }
        public int? fat { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string display_name { get; set; }
        public string type { get; set; }
        public int? id { get; set; }
    }

    public class Show
    {
        public int? id { get; set; }
        public string name { get; set; }
    }

    public class Result
    {
        public bool? is_one_top { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string thumbnail_url { get; set; }
        public object beauty_url { get; set; }
        public object brand_id { get; set; }
        public object buzz_id { get; set; }
        public int? id { get; set; }
        public List<Section> sections { get; set; }
        public UserRatings user_ratings { get; set; }
        public string original_video_url { get; set; }
        public List<object> facebook_posts { get; set; }
        public List<Rendition> renditions { get; set; }
        public int? approved_at { get; set; }
        public object cook_time_minutes { get; set; }
        public object inspired_by_url { get; set; }
        public List<Instruction> instructions { get; set; }
        public List<Credit> credits { get; set; }
        public object description { get; set; }
        public bool? is_shoppable { get; set; }
        public bool? tips_and_ratings_enabled { get; set; }
        public List<object> compilations { get; set; }
        public object seo_title { get; set; }
        public string canonical_id { get; set; }
        public string nutrition_visibility { get; set; }
        public object total_time_tier { get; set; }
        public int? num_servings { get; set; }
        public object prep_time_minutes { get; set; }
        public string servings_noun_plural { get; set; }
        public int? show_id { get; set; }
        public object total_time_minutes { get; set; }
        public int? updated_at { get; set; }
        public string video_url { get; set; }
        public string country { get; set; }
        public int? created_at { get; set; }
        public string draft_status { get; set; }
        public string language { get; set; }
        public Nutrition nutrition { get; set; }
        public object keywords { get; set; }
        public string yields { get; set; }
        public object brand { get; set; }
        public string video_ad_content { get; set; }
        public List<Tag> tags { get; set; }
        public Show show { get; set; }
        public string aspect_ratio { get; set; }
        public string promotion { get; set; }
        public string servings_noun_singular { get; set; }
        public int? video_id { get; set; }
    }

    public class Root
    {
        public int count { get; set; }
        public List<Result> results { get; set; }
    }

}