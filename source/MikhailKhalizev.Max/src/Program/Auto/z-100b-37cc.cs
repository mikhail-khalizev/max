using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_37cc-d801d631")]
        public void Method_100b_37cc()
        {
            ii(0x100b_37cc, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_37d1, 5); call(Definitions.sys_check_available_stack_size, 0xb_257c); /* call 0x10165d52 */
            ii(0x100b_37d6, 1); push(ebx);                              /* push ebx */
            ii(0x100b_37d7, 1); push(ecx);                              /* push ecx */
            ii(0x100b_37d8, 1); push(edx);                              /* push edx */
            ii(0x100b_37d9, 1); push(esi);                              /* push esi */
            ii(0x100b_37da, 1); push(edi);                              /* push edi */
            ii(0x100b_37db, 1); push(ebp);                              /* push ebp */
            ii(0x100b_37dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_37de, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100b_37e4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_37e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_37e9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_37ec, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_37ef, 5); call(0x1013_ad71, 0x8_757d);            /* call 0x1013ad71 */
            ii(0x100b_37f4, 2); test(al, al);                           /* test al, al */
            ii(0x100b_37f6, 2); if(jz(0x100b_383b, 0x43)) goto l_0x100b_383b; /* jz 0x100b383b */
            ii(0x100b_37f8, 5); call(0x1008_ac50, -0x2_8bad);           /* call 0x1008ac50 */
            ii(0x100b_37fd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_37ff, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_3801, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_3804, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3807, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_380a, 5); call(0x1007_6574, -0x3_d29b);           /* call 0x10076574 */
            ii(0x100b_380f, 5); call(0x1015_2962, 0x9_f14e);            /* call 0x10152962 */
            ii(0x100b_3814, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3816, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3819, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_381c, 5); call(0x1007_6630, -0x3_d1f1);           /* call 0x10076630 */
            ii(0x100b_3821, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3823, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3826, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_3829, 5); call(0x1008_afe4, -0x2_884a);           /* call 0x1008afe4 */
            ii(0x100b_382e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_3831, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_3836, 5); call(0x100a_5e27, -0xda14);             /* call 0x100a5e27 */
        l_0x100b_383b:
            ii(0x100b_383b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_383d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_383e, 1); pop(edi);                               /* pop edi */
            ii(0x100b_383f, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3840, 1); pop(edx);                               /* pop edx */
            ii(0x100b_3841, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3842, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3843, 1); ret();                                  /* ret */
        }
    }
}
