using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b118df2a-9db6-48e2-ba53-c8bc6b7ae1a5")]
        public void Method_1007_f21b()
        {
            ii(0x1007_f21b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_f220, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6b2d); /* call 0x10165d52 */
            ii(0x1007_f225, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_f226, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_f227, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f228, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f229, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f22a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f22c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_f232, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_f235, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_f238, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_f23b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_f23e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f241, 5); calld(0x1007_6e00, -0x8446);            /* call 0x10076e00 */
            ii(0x1007_f246, 2); test(al, al);                           /* test al, al */
            ii(0x1007_f248, 2); if(jzd(0x1007_f271, 0x27)) goto l_0x1007_f271; /* jz 0x1007f271 */
            ii(0x1007_f24a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f24c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_f24f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f252, 5); calld(0x1007_6630, -0x8c27);            /* call 0x10076630 */
            ii(0x1007_f257, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f259, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_f25c, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_f25f, 5); calld(0x1008_afe4, 0xbd80);             /* call 0x1008afe4 */
            ii(0x1007_f264, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_f267, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_f26c, 5); calld(0x100a_5e27, 0x2_6bb6);           /* call 0x100a5e27 */
        l_0x1007_f271:
            ii(0x1007_f271, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f273, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f274, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f275, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f276, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_f277, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_f278, 1); retd(); return;                         /* ret */
        }
    }
}
