using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c649c3c-3141-4274-bb32-03e5c5e7a185")]
        public void Method_1008_9640()
        {
            ii(0x1008_9640, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_9645, 5); calld(Definitions.sys_check_available_stack_size, 0xdc708); /* call 0x10165d52 */
            ii(0x1008_964a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_964b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_964c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_964d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_964e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_964f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9650, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9652, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9658, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_965b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_965e, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1008_9661, 2); if(jzd(0x1008_966c, 0x9)) goto l_0x1008_966c; /* jz 0x1008966c */
            ii(0x1008_9663, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_966a, 2); jmpd(0x1008_9685, 0x19); goto l_0x1008_9685; /* jmp 0x10089685 */
        l_0x1008_966c:
            ii(0x1008_966c, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1008_9671, 5); mov(ebx, 0x101a_02c3);                  /* mov ebx, 0x101a02c3 */ /* "smartptr.h" */
            ii(0x1008_9676, 5); mov(edx, 0x101a_02ce);                  /* mov edx, 0x101a02ce */ /* "ptr != 0" */
            ii(0x1008_967b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_967d, 5); calld(Definitions.sys_assert, 0xdc710); /* call 0x10165d92 */
            ii(0x1008_9682, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1008_9685:
            ii(0x1008_9685, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9688, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_968a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_968d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9690, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9692, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9693, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9694, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9695, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9696, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9697, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9698, 1); retd(); return;                         /* ret */
        }
    }
}