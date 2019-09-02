using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_a3b3-dd3f6e1f")]
        public void Method_1007_a3b3()
        {
            ii(0x1007_a3b3, 5); push(0x38);                             /* push 0x38 */
            ii(0x1007_a3b8, 5); call(Definitions.sys_check_available_stack_size, 0xe_b995); /* call 0x10165d52 */
            ii(0x1007_a3bd, 1); push(ebx);                              /* push ebx */
            ii(0x1007_a3be, 1); push(ecx);                              /* push ecx */
            ii(0x1007_a3bf, 1); push(edx);                              /* push edx */
            ii(0x1007_a3c0, 1); push(esi);                              /* push esi */
            ii(0x1007_a3c1, 1); push(edi);                              /* push edi */
            ii(0x1007_a3c2, 1); push(ebp);                              /* push ebp */
            ii(0x1007_a3c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_a3c5, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_a3cb, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_a3ce, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_a3d1, 5); call(0x1015_26ac, 0xd_82d6);            /* call 0x101526ac */
            ii(0x1007_a3d6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1007_a3d9:
            ii(0x1007_a3d9, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1007_a3dd, 6); if(jz(0x1007_a460, 0x7d)) goto l_0x1007_a460; /* jz 0x1007a460 */
            ii(0x1007_a3e3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a3e6, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_a3e9, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_a3ec, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1007_a3ef, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_a3f2, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x1007_a3f5, 2); cmp(al, 2);                             /* cmp al, 0x2 */
            ii(0x1007_a3f7, 2); if(jnz(0x1007_a401, 8)) goto l_0x1007_a401; /* jnz 0x1007a401 */
            ii(0x1007_a3f9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a3fc, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_a3ff, 2); jmp(0x1007_a467, 0x66); goto l_0x1007_a467; /* jmp 0x1007a467 */
        l_0x1007_a401:
            ii(0x1007_a401, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a404, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1007_a407, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_a40a, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1007_a40d, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_a410, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x1007_a413, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x1007_a415, 2); if(jz(0x1007_a42d, 0x16)) goto l_0x1007_a42d; /* jz 0x1007a42d */
            ii(0x1007_a417, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a41a, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1007_a41d, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1007_a420, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1007_a423, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1007_a426, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x1007_a429, 2); cmp(al, 0x10);                          /* cmp al, 0x10 */
            ii(0x1007_a42b, 2); if(jnz(0x1007_a42f, 2)) goto l_0x1007_a42f; /* jnz 0x1007a42f */
        l_0x1007_a42d:
            ii(0x1007_a42d, 2); jmp(0x1007_a445, 0x16); goto l_0x1007_a445; /* jmp 0x1007a445 */
        l_0x1007_a42f:
            ii(0x1007_a42f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a432, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_a435, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_a438, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1007_a43b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_a43e, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x1007_a441, 2); cmp(al, 0x14);                          /* cmp al, 0x14 */
            ii(0x1007_a443, 2); if(jnz(0x1007_a447, 2)) goto l_0x1007_a447; /* jnz 0x1007a447 */
        l_0x1007_a445:
            ii(0x1007_a445, 2); jmp(0x1007_a450, 9); goto l_0x1007_a450; /* jmp 0x1007a450 */
        l_0x1007_a447:
            ii(0x1007_a447, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_a44e, 2); jmp(0x1007_a467, 0x17); goto l_0x1007_a467; /* jmp 0x1007a467 */
        l_0x1007_a450:
            ii(0x1007_a450, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a453, 5); call(0x1008_ad58, 0x1_0900);            /* call 0x1008ad58 */
            ii(0x1007_a458, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_a45b, 5); jmp(0x1007_a3d9, -0x87); goto l_0x1007_a3d9; /* jmp 0x1007a3d9 */
        l_0x1007_a460:
            ii(0x1007_a460, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_a467:
            ii(0x1007_a467, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_a46a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_a46c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_a46d, 1); pop(edi);                               /* pop edi */
            ii(0x1007_a46e, 1); pop(esi);                               /* pop esi */
            ii(0x1007_a46f, 1); pop(edx);                               /* pop edx */
            ii(0x1007_a470, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_a471, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_a472, 1); ret();                                  /* ret */
        }
    }
}
