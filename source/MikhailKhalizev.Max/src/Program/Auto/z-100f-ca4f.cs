using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_ca4f-6a8a8686")]
        public void Method_100f_ca4f()
        {
            ii(0x100f_ca4f, 5); push(0x28);                             /* push 0x28 */
            ii(0x100f_ca54, 5); call(Definitions.sys_check_available_stack_size, 0x6_92f9); /* call 0x10165d52 */
            ii(0x100f_ca59, 1); push(ebx);                              /* push ebx */
            ii(0x100f_ca5a, 1); push(ecx);                              /* push ecx */
            ii(0x100f_ca5b, 1); push(edx);                              /* push edx */
            ii(0x100f_ca5c, 1); push(esi);                              /* push esi */
            ii(0x100f_ca5d, 1); push(edi);                              /* push edi */
            ii(0x100f_ca5e, 1); push(ebp);                              /* push ebp */
            ii(0x100f_ca5f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ca61, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_ca67, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_ca6a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_ca6d, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_ca70, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_ca73, 2); jmp(0x100f_ca79, 0x4); goto l_0x100f_ca79; /* jmp 0x100fca79 */
        l_0x100f_ca75:
            ii(0x100f_ca75, 4); add(memd[ss, ebp - 0xc], 0x2);          /* add dword [ebp-0xc], 0x2 */
        l_0x100f_ca79:
            ii(0x100f_ca79, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_ca7c, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100f_ca83, 2); if(jge(0x100f_cade, 0x59)) goto l_0x100f_cade; /* jge 0x100fcade */
            ii(0x100f_ca85, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_ca88, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x100f_ca8c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_ca8f, 2); jmp(0x100f_ca95, 0x4); goto l_0x100f_ca95; /* jmp 0x100fca95 */
        l_0x100f_ca91:
            ii(0x100f_ca91, 4); add(memd[ss, ebp - 0x8], 0x2);          /* add dword [ebp-0x8], 0x2 */
        l_0x100f_ca95:
            ii(0x100f_ca95, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_ca98, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100f_ca9f, 2); if(jge(0x100f_cadc, 0x3b)) goto l_0x100f_cadc; /* jge 0x100fcadc */
            ii(0x100f_caa1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_caa4, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100f_caa7, 5); call(0x100f_c32c, -0x780);              /* call 0x100fc32c */
            ii(0x100f_caac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_caae, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_cab1, 4); mov(bx, memw[ds, eax + 0x4]);           /* mov bx, [eax+0x4] */
            ii(0x100f_cab5, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100f_cab7, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_cabb, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100f_cac1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_cac4, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100f_cac7, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_cacb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cacd, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_cacf, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x100f_cad5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cad7, 3); mov(memw[ds, eax], bx);                 /* mov [eax], bx */
            ii(0x100f_cada, 2); jmp(0x100f_ca91, -0x4b); goto l_0x100f_ca91; /* jmp 0x100fca91 */
        l_0x100f_cadc:
            ii(0x100f_cadc, 2); jmp(0x100f_ca75, -0x69); goto l_0x100f_ca75; /* jmp 0x100fca75 */
        l_0x100f_cade:
            ii(0x100f_cade, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_cae0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_cae1, 1); pop(edi);                               /* pop edi */
            ii(0x100f_cae2, 1); pop(esi);                               /* pop esi */
            ii(0x100f_cae3, 1); pop(edx);                               /* pop edx */
            ii(0x100f_cae4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_cae5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_cae6, 1); ret();                                  /* ret */
        }
    }
}
