using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1ff5-914140fc")]
        public void Method_1007_1ff5()
        {
            ii(0x1007_1ff5, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1007_1ffa, 5); call(Definitions.sys_check_available_stack_size, 0xf_3d53); /* call 0x10165d52 */
            ii(0x1007_1fff, 1); push(ebx);                              /* push ebx */
            ii(0x1007_2000, 1); push(ecx);                              /* push ecx */
            ii(0x1007_2001, 1); push(edx);                              /* push edx */
            ii(0x1007_2002, 1); push(esi);                              /* push esi */
            ii(0x1007_2003, 1); push(edi);                              /* push edi */
            ii(0x1007_2004, 1); push(ebp);                              /* push ebp */
            ii(0x1007_2005, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2007, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_200d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_2010, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_2013, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_2016, 2); jmp(0x1007_2040, 0x28); goto l_0x1007_2040; /* jmp 0x10072040 */
        l_0x1007_2018:
            ii(0x1007_2018, 7); mov(memd[ss, ebp - 12], 0xffff_fffd);   /* mov dword [ebp-0xc], 0xfffffffd */
            ii(0x1007_201f, 2); jmp(0x1007_2067, 0x46); goto l_0x1007_2067; /* jmp 0x10072067 */
        l_0x1007_2021:
            ii(0x1007_2021, 7); mov(memd[ss, ebp - 12], 1);             /* mov dword [ebp-0xc], 0x1 */
            ii(0x1007_2028, 2); jmp(0x1007_2067, 0x3d); goto l_0x1007_2067; /* jmp 0x10072067 */
        l_0x1007_202a:
            ii(0x1007_202a, 2); jmp(0x1007_2060, 0x34); goto l_0x1007_2060; /* jmp 0x10072060 */
        //  ii(0x1007_202c, 20); /* Служебная область с абсолютными адресами переходов. (0x1007_2018, 0x1007_2021, 0x1007_2021, 0x1007_202a, 0x1007_2021). */
        l_0x1007_2040:
            ii(0x1007_2040, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_2043, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x1007_2046, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_2049, 5); cmp(memw[ss, ebp - 16], 4);             /* cmp word [ebp-0x10], 0x4 */
            ii(0x1007_204e, 2); if(ja(0x1007_202a, -0x26)) goto l_0x1007_202a; /* ja 0x1007202a */
            ii(0x1007_2050, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_2052, 4); mov(ax, memw[ss, ebp - 16]);            /* mov ax, [ebp-0x10] */
            ii(0x1007_2056, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1007_2059, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1007_202c]))
            {
                case 0x1007_2018:
                    goto l_0x1007_2018;
                case 0x1007_2021:
                    goto l_0x1007_2021;
                case 0x1007_202a:
                    goto l_0x1007_202a;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x1007202c] */
        l_0x1007_2060:
            ii(0x1007_2060, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_2067:
            ii(0x1007_2067, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_206a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_206c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_206d, 1); pop(edi);                               /* pop edi */
            ii(0x1007_206e, 1); pop(esi);                               /* pop esi */
            ii(0x1007_206f, 1); pop(edx);                               /* pop edx */
            ii(0x1007_2070, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_2071, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_2072, 1); ret();                                  /* ret */
        }
    }
}
