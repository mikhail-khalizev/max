using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_23e4-eaf458fb")]
        public void Method_100a_23e4()
        {
            ii(0x100a_23e4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_23e9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_3964); /* call 0x10165d52 */
            ii(0x100a_23ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_23ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_23f0, 1); pushd(esi);                             /* push esi */
            ii(0x100a_23f1, 1); pushd(edi);                             /* push edi */
            ii(0x100a_23f2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_23f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_23f5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_23fb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_23fe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2401, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_2405, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_2409, 5); calld(0x100d_4b64, 0x3_2756);           /* call 0x100d4b64 */
            ii(0x100a_240e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_2411, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_2415, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_2418, 9); test(memw_a32[ds, eax + 0x101c_81c0], 0x1c0); /* test word [eax+0x101c81c0], 0x1c0 */
            ii(0x100a_2421, 2); if(jzd(0x100a_243d, 0x1a)) goto l_0x100a_243d; /* jz 0x100a243d */
            ii(0x100a_2423, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_2428, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x100a_242d, 5); calld(0x1007_1e00, -0x3_0632);          /* call 0x10071e00 */
            ii(0x100a_2432, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_2435, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_2438, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_243b, 2); jmpd(0x100a_2455, 0x18); goto l_0x100a_2455; /* jmp 0x100a2455 */
        l_0x100a_243d:
            ii(0x100a_243d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_2442, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100a_2447, 5); calld(0x1007_1e00, -0x3_064c);          /* call 0x10071e00 */
            ii(0x100a_244c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_244f, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_2452, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
        l_0x100a_2455:
            ii(0x100a_2455, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_2458, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_245b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_245e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2460, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2461, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2462, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2463, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2464, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2465, 1); retd(); return;                         /* ret */
        }
    }
}
