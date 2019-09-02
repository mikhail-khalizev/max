using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1913-6da0df2a")]
        public void Method_100b_1913()
        {
            ii(0x100b_1913, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_1918, 5); call(Definitions.sys_check_available_stack_size, 0xb_4435); /* call 0x10165d52 */
            ii(0x100b_191d, 1); push(ebx);                              /* push ebx */
            ii(0x100b_191e, 1); push(ecx);                              /* push ecx */
            ii(0x100b_191f, 1); push(esi);                              /* push esi */
            ii(0x100b_1920, 1); push(edi);                              /* push edi */
            ii(0x100b_1921, 1); push(ebp);                              /* push ebp */
            ii(0x100b_1922, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1924, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_192a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_192d, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_1930, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1932, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1935, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1938, 5); call(0x1013_ad11, 0x8_93d4);            /* call 0x1013ad11 */
            ii(0x100b_193d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_193f, 2); if(jz(0x100b_1951, 0x10)) goto l_0x100b_1951; /* jz 0x100b1951 */
            ii(0x100b_1941, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1944, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x100b_1948, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_194b, 4); cmp(dx, memw[ds, eax + 0x13]);          /* cmp dx, [eax+0x13] */
            ii(0x100b_194f, 2); if(jz(0x100b_1953, 2)) goto l_0x100b_1953; /* jz 0x100b1953 */
        l_0x100b_1951:
            ii(0x100b_1951, 2); jmp(0x100b_198d, 0x3a); goto l_0x100b_198d; /* jmp 0x100b198d */
        l_0x100b_1953:
            ii(0x100b_1953, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_1956, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1959, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_195c, 5); call(0x1007_6630, -0x3_b331);           /* call 0x10076630 */
            ii(0x100b_1961, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_1964, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1967, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_196a, 5); call(0x1007_6574, -0x3_b3fb);           /* call 0x10076574 */
            ii(0x100b_196f, 5); call(0x1015_27ed, 0xa_0e79);            /* call 0x101527ed */
            ii(0x100b_1974, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1977, 5); call(0x100b_1e09, 0x48d);               /* call 0x100b1e09 */
            ii(0x100b_197c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_197e, 2); if(jz(0x100b_198d, 0xd)) goto l_0x100b_198d; /* jz 0x100b198d */
            ii(0x100b_1980, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_1985, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1988, 5); call(0x100a_297d, -0xf010);             /* call 0x100a297d */
        l_0x100b_198d:
            ii(0x100b_198d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_198f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_1990, 1); pop(edi);                               /* pop edi */
            ii(0x100b_1991, 1); pop(esi);                               /* pop esi */
            ii(0x100b_1992, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_1993, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_1994, 1); ret();                                  /* ret */
        }
    }
}
