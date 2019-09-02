using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_bad9-c5bb824")]
        public void Method_100c_bad9()
        {
            ii(0x100c_bad9, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_bade, 5); call(Definitions.sys_check_available_stack_size, 0x9_a26f); /* call 0x10165d52 */
            ii(0x100c_bae3, 1); push(ebx);                              /* push ebx */
            ii(0x100c_bae4, 1); push(ecx);                              /* push ecx */
            ii(0x100c_bae5, 1); push(edx);                              /* push edx */
            ii(0x100c_bae6, 1); push(esi);                              /* push esi */
            ii(0x100c_bae7, 1); push(edi);                              /* push edi */
            ii(0x100c_bae8, 1); push(ebp);                              /* push ebp */
            ii(0x100c_bae9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_baeb, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100c_baf1, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_baf4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_baf6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_baf9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_bafc, 5); call(0x1013_ad71, 0x6_f270);            /* call 0x1013ad71 */
            ii(0x100c_bb01, 2); test(al, al);                           /* test al, al */
            ii(0x100c_bb03, 2); if(jz(0x100c_bb21, 0x1c)) goto l_0x100c_bb21; /* jz 0x100cbb21 */
            ii(0x100c_bb05, 5); call(0x1008_ac50, -0x4_0eba);           /* call 0x1008ac50 */
            ii(0x100c_bb0a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_bb0c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_bb0e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_bb11, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_bb14, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_bb17, 5); call(0x1007_6574, -0x5_55a8);           /* call 0x10076574 */
            ii(0x100c_bb1c, 5); call(0x1015_2962, 0x8_6e41);            /* call 0x10152962 */
        l_0x100c_bb21:
            ii(0x100c_bb21, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bb23, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_bb26, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_bb29, 5); call(0x1013_ad71, 0x6_f243);            /* call 0x1013ad71 */
            ii(0x100c_bb2e, 2); test(al, al);                           /* test al, al */
            ii(0x100c_bb30, 2); if(jz(0x100c_bb4e, 0x1c)) goto l_0x100c_bb4e; /* jz 0x100cbb4e */
            ii(0x100c_bb32, 5); call(0x1008_ac50, -0x4_0ee7);           /* call 0x1008ac50 */
            ii(0x100c_bb37, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_bb39, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_bb3b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_bb3e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_bb41, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_bb44, 5); call(0x1007_6574, -0x5_55d5);           /* call 0x10076574 */
            ii(0x100c_bb49, 5); call(0x1015_2962, 0x8_6e14);            /* call 0x10152962 */
        l_0x100c_bb4e:
            ii(0x100c_bb4e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bb50, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_bb53, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_bb56, 5); call(0x1007_6630, -0x5_552b);           /* call 0x10076630 */
            ii(0x100c_bb5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bb5d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_bb60, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_bb63, 5); call(0x1007_6630, -0x5_5538);           /* call 0x10076630 */
            ii(0x100c_bb68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bb6a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_bb6d, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100c_bb70, 5); call(0x1008_afe4, -0x4_0b91);           /* call 0x1008afe4 */
            ii(0x100c_bb75, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_bb78, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_bb7d, 5); call(0x100a_5e27, -0x2_5d5b);           /* call 0x100a5e27 */
            ii(0x100c_bb82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_bb84, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_bb85, 1); pop(edi);                               /* pop edi */
            ii(0x100c_bb86, 1); pop(esi);                               /* pop esi */
            ii(0x100c_bb87, 1); pop(edx);                               /* pop edx */
            ii(0x100c_bb88, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_bb89, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_bb8a, 1); ret();                                  /* ret */
        }
    }
}
