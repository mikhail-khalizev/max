using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_42dd-29df63bc")]
        public void Method_1016_42dd()
        {
            ii(0x1016_42dd, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1016_42e2, 5); calld(Definitions.sys_check_available_stack_size, 0x1a6b); /* call 0x10165d52 */
            ii(0x1016_42e7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_42e8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_42e9, 1); pushd(edx);                             /* push edx */
            ii(0x1016_42ea, 1); pushd(esi);                             /* push esi */
            ii(0x1016_42eb, 1); pushd(edi);                             /* push edi */
            ii(0x1016_42ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_42ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_42ef, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1016_42f5, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1016_42fa, 5); calld(Definitions.sys_new, 0x1b01);     /* call 0x10165e00 */
            ii(0x1016_42ff, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_4302, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4305, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4308, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1016_430c, 2); if(jzd(0x1016_4323, 0x15)) goto l_0x1016_4323; /* jz 0x10164323 */
            ii(0x1016_430e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_4310, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4313, 5); calld(0x1016_3dd9, -0x53f);             /* call 0x10163dd9 */
            ii(0x1016_4318, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_431b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_431e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4321, 2); jmpd(0x1016_4329, 0x6); goto l_0x1016_4329; /* jmp 0x10164329 */
        l_0x1016_4323:
            ii(0x1016_4323, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_4326, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1016_4329:
            ii(0x1016_4329, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_432c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1016_432f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1016_4332, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4334, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4335, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4336, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4337, 1); popd(edx);                              /* pop edx */
            ii(0x1016_4338, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4339, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_433a, 1); retd(); return;                         /* ret */
        }
    }
}
