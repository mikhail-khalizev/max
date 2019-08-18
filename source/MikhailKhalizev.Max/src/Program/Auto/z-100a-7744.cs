using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7744-4e63607")]
        public void Method_100a_7744()
        {
            ii(0x100a_7744, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_7749, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e604); /* call 0x10165d52 */
            ii(0x100a_774e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_774f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_7750, 1); pushd(edx);                             /* push edx */
            ii(0x100a_7751, 1); pushd(esi);                             /* push esi */
            ii(0x100a_7752, 1); pushd(edi);                             /* push edi */
            ii(0x100a_7753, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_7754, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7756, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_775c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_775f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7762, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7765, 5); calld(0x1013_b325, 0x9_3bbb);           /* call 0x1013b325 */
            ii(0x100a_776a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_776c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_776f, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_7772, 5); calld(0x1013_ad71, 0x9_35fa);           /* call 0x1013ad71 */
            ii(0x100a_7777, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7779, 2); if(jzd(0x100a_7797, 0x1c)) goto l_0x100a_7797; /* jz 0x100a7797 */
            ii(0x100a_777b, 5); calld(0x1008_ac50, -0x1_cb30);          /* call 0x1008ac50 */
            ii(0x100a_7780, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_7782, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_7784, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_7787, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_778a, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_778d, 5); calld(0x1007_6574, -0x3_121e);          /* call 0x10076574 */
            ii(0x100a_7792, 5); calld(0x1015_2962, 0xa_b1cb);           /* call 0x10152962 */
        l_0x100a_7797:
            ii(0x100a_7797, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7799, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_779c, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_779f, 5); calld(0x1007_6630, -0x3_1174);          /* call 0x10076630 */
            ii(0x100a_77a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_77a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_77a9, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_77ac, 5); calld(0x1008_afe4, -0x1_c7cd);          /* call 0x1008afe4 */
            ii(0x100a_77b1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_77b4, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_77b9, 5); calld(0x100a_5e27, -0x1997);            /* call 0x100a5e27 */
            ii(0x100a_77be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_77c0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_77c1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_77c2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_77c3, 1); popd(edx);                              /* pop edx */
            ii(0x100a_77c4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_77c5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_77c6, 1); retd(); return;                         /* ret */
        }
    }
}
