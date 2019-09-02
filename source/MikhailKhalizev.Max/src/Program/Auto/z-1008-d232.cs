using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d232-3b9a1c6a")]
        public void Method_1008_d232()
        {
            ii(0x1008_d232, 5); push(0x34);                             /* push 0x34 */
            ii(0x1008_d237, 5); call(Definitions.sys_check_available_stack_size, 0xd_8b16); /* call 0x10165d52 */
            ii(0x1008_d23c, 1); push(ebx);                              /* push ebx */
            ii(0x1008_d23d, 1); push(ecx);                              /* push ecx */
            ii(0x1008_d23e, 1); push(edx);                              /* push edx */
            ii(0x1008_d23f, 1); push(esi);                              /* push esi */
            ii(0x1008_d240, 1); push(edi);                              /* push edi */
            ii(0x1008_d241, 1); push(ebp);                              /* push ebp */
            ii(0x1008_d242, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d244, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_d24a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_d24d, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1008_d252, 5); call(Definitions.sys_new, 0xd_8ba9);    /* call 0x10165e00 */
            ii(0x1008_d257, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_d25a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_d25d, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_d260, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1008_d264, 2); if(jz(0x1008_d282, 0x1c)) goto l_0x1008_d282; /* jz 0x1008d282 */
            ii(0x1008_d266, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1008_d269, 3); add(ebx, 0x21);                         /* add ebx, 0x21 */
            ii(0x1008_d26c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_d26f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_d272, 5); call(Definitions.my_ctor_c12, 0x1_8df5); /* call 0x100a606c */
            ii(0x1008_d277, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1008_d27a, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_d27d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_d280, 2); jmp(0x1008_d288, 6); goto l_0x1008_d288; /* jmp 0x1008d288 */
        l_0x1008_d282:
            ii(0x1008_d282, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_d285, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1008_d288:
            ii(0x1008_d288, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_d28b, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1008_d28e, 5); call(0x1008_a914, -0x297f);             /* call 0x1008a914 */
            ii(0x1008_d293, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_d296, 4); mov(memb[ds, eax + 37], 3);             /* mov byte [eax+0x25], 0x3 */
            ii(0x1008_d29a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_d29d, 3); mov(eax, memd[ds, eax + 17]);           /* mov eax, [eax+0x11] */
            ii(0x1008_d2a0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_d2a3, 5); call(0x100c_defa, 0x4_0c52);            /* call 0x100cdefa */
            ii(0x1008_d2a8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_d2ab, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1008_d2ae, 5); call(0x1008_a7dc, -0x2ad7);             /* call 0x1008a7dc */
            ii(0x1008_d2b3, 5); call(0x100a_63bc, 0x1_9104);            /* call 0x100a63bc */
            ii(0x1008_d2b8, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1008_d2bb, 5); call(0x1008_a868, -0x2a58);             /* call 0x1008a868 */
            ii(0x1008_d2c0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d2c2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_d2c7, 5); call(0x100a_4d50, 0x1_7a84);            /* call 0x100a4d50 */
            ii(0x1008_d2cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d2ce, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1008_d2d1, 5); call(0x1008_8cbc, -0x461a);             /* call 0x10088cbc */
            ii(0x1008_d2d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_d2d8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_d2d9, 1); pop(edi);                               /* pop edi */
            ii(0x1008_d2da, 1); pop(esi);                               /* pop esi */
            ii(0x1008_d2db, 1); pop(edx);                               /* pop edx */
            ii(0x1008_d2dc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_d2dd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_d2de, 1); ret();                                  /* ret */
        }
    }
}
