using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9291-d45aaf95")]
        public void Method_1015_9291()
        {
            ii(0x1015_9291, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_9296, 5); calld(Definitions.sys_check_available_stack_size, 0xcab7); /* call 0x10165d52 */
            ii(0x1015_929b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_929c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_929d, 1); pushd(esi);                             /* push esi */
            ii(0x1015_929e, 1); pushd(edi);                             /* push edi */
            ii(0x1015_929f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_92a0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_92a2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_92a8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_92ab, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_92ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_92b1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_92b4, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_92b9, 5); calld(0x100f_448c, -0x6_4e32);          /* call 0x100f448c */
            ii(0x1015_92be, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_92c1, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_92c5, 2); if(jnzd(0x1015_92d9, 0x12)) goto l_0x1015_92d9; /* jnz 0x101592d9 */
            ii(0x1015_92c7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_92ca, 5); calld(0x100f_3f62, -0x6_536d);          /* call 0x100f3f62 */
            ii(0x1015_92cf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_92d2, 5); calld(0x100f_fa70, -0x5_9867);          /* call 0x100ffa70 */
            ii(0x1015_92d7, 2); jmpd(0x1015_92fc, 0x23); goto l_0x1015_92fc; /* jmp 0x101592fc */
        l_0x1015_92d9:
            ii(0x1015_92d9, 5); calld(0x100f_fc13, -0x5_96cb);          /* call 0x100ffc13 */
            ii(0x1015_92de, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_92e1, 5); calld(0x100d_4a9e, -0x8_4848);          /* call 0x100d4a9e */
            ii(0x1015_92e6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_92e8, 2); if(jzd(0x1015_92f4, 0xa)) goto l_0x1015_92f4; /* jz 0x101592f4 */
            ii(0x1015_92ea, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_92ed, 5); calld(0x1010_19b8, -0x5_793a);          /* call 0x101019b8 */
            ii(0x1015_92f2, 2); jmpd(0x1015_92fc, 0x8); goto l_0x1015_92fc; /* jmp 0x101592fc */
        l_0x1015_92f4:
            ii(0x1015_92f4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_92f7, 5); calld(0x100f_fa70, -0x5_988c);          /* call 0x100ffa70 */
        l_0x1015_92fc:
            ii(0x1015_92fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_92fe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_92ff, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9300, 1); popd(esi);                              /* pop esi */
            ii(0x1015_9301, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_9302, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_9303, 1); retd(); return;                         /* ret */
        }
    }
}
