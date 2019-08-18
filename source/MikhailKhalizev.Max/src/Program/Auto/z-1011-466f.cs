using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("50933327-6fa7-47d9-a635-9ee346824a12")]
        public void Method_1011_466f()
        {
            ii(0x1011_466f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_4674, 5); calld(Definitions.sys_check_available_stack_size, 0x5_16d9); /* call 0x10165d52 */
            ii(0x1011_4679, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_467a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_467b, 1); pushd(edx);                             /* push edx */
            ii(0x1011_467c, 1); pushd(esi);                             /* push esi */
            ii(0x1011_467d, 1); pushd(edi);                             /* push edi */
            ii(0x1011_467e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_467f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_4681, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_4687, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_468a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_468d, 5); calld(0x1011_3b89, -0xb09);             /* call 0x10113b89 */
            ii(0x1011_4692, 7); cmp(memb_a32[ds, 0x101c_391e], 0x6);    /* cmp byte [0x101c391e], 0x6 */
            ii(0x1011_4699, 2); if(jnzd(0x1011_46a7, 0xc)) goto l_0x1011_46a7; /* jnz 0x101146a7 */
            ii(0x1011_469b, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1011_46a0, 5); calld(0x1010_bf06, -0x879f);            /* call 0x1010bf06 */
            ii(0x1011_46a5, 2); jmpd(0x1011_46b1, 0xa); goto l_0x1011_46b1; /* jmp 0x101146b1 */
        l_0x1011_46a7:
            ii(0x1011_46a7, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1011_46ac, 5); calld(0x1010_bf06, -0x87ab);            /* call 0x1010bf06 */
        l_0x1011_46b1:
            ii(0x1011_46b1, 6); mov(edx, memd_a32[ds, 0x101c_391b]);    /* mov edx, [0x101c391b] */
            ii(0x1011_46b7, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_46ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_46bd, 5); calld(0x1011_2a06, -0x1cbc);            /* call 0x10112a06 */
            ii(0x1011_46c2, 5); calld(0x1012_abdb, 0x1_6514);           /* call 0x1012abdb */
            ii(0x1011_46c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_46c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_46cc, 5); calld(0x1011_3aca, -0xc07);             /* call 0x10113aca */
            ii(0x1011_46d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_46d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_46d4, 1); popd(edi);                              /* pop edi */
            ii(0x1011_46d5, 1); popd(esi);                              /* pop esi */
            ii(0x1011_46d6, 1); popd(edx);                              /* pop edx */
            ii(0x1011_46d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_46d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_46d9, 1); retd(); return;                         /* ret */
        }
    }
}
