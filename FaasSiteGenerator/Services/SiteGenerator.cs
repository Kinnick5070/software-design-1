

public class SiteGenerator{

    public required string BaseDirPath {get; set;}

    public required string WriteDirPath {get; set;}

    


    private string GenerateBottomScripts(int id) {
        return $@"
            <script src=""https://cdnjs.cloudflare.com/ajax/libs/aos/2.3.4/aos.js"" integrity=""sha512-A7AYk1fGKX6S2SsHywmPkrnzTZHrgiVT7GcQkLGDe2ev0aWb8zejytzS8wjo7PGEXKqJOrjQ4oORtnimIRZBtw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
            <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN"" crossorigin=""anonymous""></script>
            <script src=""https://cdn.tailwindcss.com""></script>
            <script type=""text/javascript"">
                AOS.init({{duration: 1200,
                }});
                
                function getValue() {{let dropdown = document.getElementById(""tv-show-select"");
                    let selectedValue = dropdown.value;
                    let url = document.URL;
                    let newUrl = url.split('/').slice(0,-1).join('/') + '/' + selectedValue + '.html';
                    window.location = newUrl;
                }}
                document.querySelector('#tv-show-select').value = {id};
    
            </script>
        ";
    }
}