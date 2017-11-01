
$path = read-host "Enter Path"
$content = Get-Content $path

$i = 0
foreach ($line in $content)
{

    if ($line -like "*=*")
    {
        $name = $($line -split " = ")[0]
        $code = $($line -split " = ")[1]
        $output = "  $title[$i]`n    name = " + $name + "`n    code = " + $code
        $i++
        write-host $output
        
    }
    else {
        $title = $line
        $i = 0
        
    }    
}