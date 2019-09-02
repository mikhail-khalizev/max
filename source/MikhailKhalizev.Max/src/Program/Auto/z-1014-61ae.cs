using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_61ae-806adaf6")]
        public void Method_1014_61ae()
        {
            ii(0x1014_61ae, 5); push(0x34);                             /* push 0x34 */
            ii(0x1014_61b3, 5); call(Definitions.sys_check_available_stack_size, 0x1_fb9a); /* call 0x10165d52 */
            ii(0x1014_61b8, 1); push(ecx);                              /* push ecx */
            ii(0x1014_61b9, 1); push(esi);                              /* push esi */
            ii(0x1014_61ba, 1); push(edi);                              /* push edi */
            ii(0x1014_61bb, 1); push(ebp);                              /* push ebp */
            ii(0x1014_61bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_61be, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_61c4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_61c7, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_61ca, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_61cd, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1014_61d0, 3); lea(edx, memd[ss, ebp - 28]);           /* lea edx, [ebp-0x1c] */
            ii(0x1014_61d3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_61d6, 5); call(0x1014_630a, 0x12f);               /* call 0x1014630a */
            ii(0x1014_61db, 4); or(memb[ss, ebp - 16], 1);              /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_61df, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1014_61e2, 5); call(0x1014_806c, 0x1e85);              /* call 0x1014806c */
            ii(0x1014_61e7, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1014_61ea, 4); and(memb[ss, ebp - 16], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_61ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_61f0, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_61f3, 5); call(0x1013_ad71, -0xb487);             /* call 0x1013ad71 */
            ii(0x1014_61f8, 2); test(al, al);                           /* test al, al */
            ii(0x1014_61fa, 2); if(jz(0x1014_621d, 0x21)) goto l_0x1014_621d; /* jz 0x1014621d */
            ii(0x1014_61fc, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_61ff, 5); call(0x100e_0760, -0x6_5aa4);           /* call 0x100e0760 */
            ii(0x1014_6204, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1014_6207, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1014_620a, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1014_620d, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1014_6210, 3); call_abs(memd[ds, edx + 16]);           /* call dword [edx+0x10] */
            ii(0x1014_6213, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6215, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1014_6218, 5); call(0x1014_7ff0, 0x1dd3);              /* call 0x10147ff0 */
        l_0x1014_621d:
            ii(0x1014_621d, 3); lea(edx, memd[ss, ebp - 24]);           /* lea edx, [ebp-0x18] */
            ii(0x1014_6220, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_6223, 5); call(0x1014_8028, 0x1e00);              /* call 0x10148028 */
            ii(0x1014_6228, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_622a, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1014_622d, 5); call(0x100e_0158, -0x6_60da);           /* call 0x100e0158 */
            ii(0x1014_6232, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6234, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_6237, 5); call(0x100e_03bc, -0x6_5e80);           /* call 0x100e03bc */
            ii(0x1014_623c, 2); jmp(0x1014_6252, 0x14); goto l_0x1014_6252; /* jmp 0x10146252 */
        //  ii(0x1014_623e, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_6240, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
        //  ii(0x1014_6243, 5); call(0x100e_0158, -0x6_60f0);           /* call 0x100e0158 */
        //  ii(0x1014_6248, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_624a, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
        //  ii(0x1014_624d, 5); call(0x100e_03bc, -0x6_5e96);           /* call 0x100e03bc */
        l_0x1014_6252:
            ii(0x1014_6252, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_6255, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6257, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_6258, 1); pop(edi);                               /* pop edi */
            ii(0x1014_6259, 1); pop(esi);                               /* pop esi */
            ii(0x1014_625a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_625b, 1); ret();                                  /* ret */
        }
    }
}
