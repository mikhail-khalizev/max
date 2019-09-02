using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_ab2f-dbee9fa2")]
        public void Method_1012_ab2f()
        {
            ii(0x1012_ab2f, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_ab34, 5); call(Definitions.sys_check_available_stack_size, 0x3_b219); /* call 0x10165d52 */
            ii(0x1012_ab39, 1); push(ebx);                              /* push ebx */
            ii(0x1012_ab3a, 1); push(ecx);                              /* push ecx */
            ii(0x1012_ab3b, 1); push(edx);                              /* push edx */
            ii(0x1012_ab3c, 1); push(esi);                              /* push esi */
            ii(0x1012_ab3d, 1); push(edi);                              /* push edi */
            ii(0x1012_ab3e, 1); push(ebp);                              /* push ebp */
            ii(0x1012_ab3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_ab41, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1012_ab47, 7); mov(memb[ds, 0x101c_5c1c], 0x23);       /* mov byte [0x101c5c1c], 0x23 */
            ii(0x1012_ab4e, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_ab53, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1012_ab57, 6); mov(memw[ds, 0x101c_5c1d], ax);         /* mov [0x101c5c1d], ax */
            ii(0x1012_ab5d, 9); mov(memw[ds, 0x101c_5c1f], 0x23);       /* mov word [0x101c5c1f], 0x23 */
            ii(0x1012_ab66, 7); mov(memd[ss, ebp - 8], 0x101c_5c21);    /* mov dword [ebp-0x8], 0x101c5c21 */
            ii(0x1012_ab6d, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_ab72, 4); mov(dx, memw[ds, eax + 0x14]);          /* mov dx, [eax+0x14] */
            ii(0x1012_ab76, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_ab79, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1012_ab7c, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_ab81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ab83, 3); mov(dl, memb[ds, eax + 0x11]);          /* mov dl, [eax+0x11] */
            ii(0x1012_ab86, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_ab89, 4); mov(memw[ds, eax + 2], dx);             /* mov [eax+0x2], dx */
            ii(0x1012_ab8d, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_ab92, 3); mov(al, memb[ds, eax + 0xb]);           /* mov al, [eax+0xb] */
            ii(0x1012_ab95, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_ab9a, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1012_ab9d, 2); if(jnz(0x1012_aba5, 6)) goto l_0x1012_aba5; /* jnz 0x1012aba5 */
            ii(0x1012_ab9f, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
            ii(0x1012_aba3, 2); jmp(0x1012_aba9, 4); goto l_0x1012_aba9; /* jmp 0x1012aba9 */
        l_0x1012_aba5:
            ii(0x1012_aba5, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
        l_0x1012_aba9:
            ii(0x1012_aba9, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1012_abac, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1012_abaf, 3); mov(memb[ds, edx + 4], al);             /* mov [edx+0x4], al */
            ii(0x1012_abb2, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_abb7, 6); lea(edx, memd[ds, eax + 0x21a]);        /* lea edx, [eax+0x21a] */
            ii(0x1012_abbd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_abc0, 3); add(eax, 5);                            /* add eax, 0x5 */
            ii(0x1012_abc3, 5); call(Definitions.sys_strcpy, 0x3_b307); /* call 0x10165ecf */
            ii(0x1012_abc8, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x1012_abcd, 5); call(0x1012_5be9, -0x4fe9);             /* call 0x10125be9 */
            ii(0x1012_abd2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_abd4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_abd5, 1); pop(edi);                               /* pop edi */
            ii(0x1012_abd6, 1); pop(esi);                               /* pop esi */
            ii(0x1012_abd7, 1); pop(edx);                               /* pop edx */
            ii(0x1012_abd8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_abd9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_abda, 1); ret();                                  /* ret */
        }
    }
}
