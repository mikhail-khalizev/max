using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_26ac-74c8f0bf")]
        public void Method_1015_26ac()
        {
            ii(0x1015_26ac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_26b1, 5); calld(Definitions.sys_check_available_stack_size, 0x1_369c); /* call 0x10165d52 */
            ii(0x1015_26b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_26b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_26b8, 1); pushd(edx);                             /* push edx */
            ii(0x1015_26b9, 1); pushd(esi);                             /* push esi */
            ii(0x1015_26ba, 1); pushd(edi);                             /* push edi */
            ii(0x1015_26bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_26bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_26be, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_26c4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_26c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_26ca, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_26cf, 5); calld(0x1007_6b90, -0xd_bb44);          /* call 0x10076b90 */
            ii(0x1015_26d4, 1); cwde();                                 /* cwde */
            ii(0x1015_26d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_26d7, 2); if(jnzd(0x1015_26e2, 0x9)) goto l_0x1015_26e2; /* jnz 0x101526e2 */
            ii(0x1015_26d9, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1015_26e0, 2); jmpd(0x1015_26f4, 0x12); goto l_0x1015_26f4; /* jmp 0x101526f4 */
        l_0x1015_26e2:
            ii(0x1015_26e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_26e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_26e7, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_26ec, 5); calld(0x1015_5164, 0x2a73);             /* call 0x10155164 */
            ii(0x1015_26f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1015_26f4:
            ii(0x1015_26f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_26f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_26f9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_26fa, 1); popd(edi);                              /* pop edi */
            ii(0x1015_26fb, 1); popd(esi);                              /* pop esi */
            ii(0x1015_26fc, 1); popd(edx);                              /* pop edx */
            ii(0x1015_26fd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_26fe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_26ff, 1); retd();                                 /* ret */
        }
    }
}
