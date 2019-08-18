using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b5f8-1c3ca60c")]
        public void Method_1011_b5f8()
        {
            ii(0x1011_b5f8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_b5fd, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a750); /* call 0x10165d52 */
            ii(0x1011_b602, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_b603, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_b604, 1); pushd(edx);                             /* push edx */
            ii(0x1011_b605, 1); pushd(esi);                             /* push esi */
            ii(0x1011_b606, 1); pushd(edi);                             /* push edi */
            ii(0x1011_b607, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_b608, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b60a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_b610, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_b613, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b616, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1011_b619, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_b61c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b61f, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b622, 5); calld(0x100b_82bc, -0x6_336b);          /* call 0x100b82bc */
            ii(0x1011_b627, 1); cwde();                                 /* cwde */
            ii(0x1011_b628, 1); inc(edx);                               /* inc edx */
            ii(0x1011_b629, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_b62b, 2); if(jnzd(0x1011_b636, 0x9)) goto l_0x1011_b636; /* jnz 0x1011b636 */
            ii(0x1011_b62d, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x1011_b634, 2); jmpd(0x1011_b63d, 0x7); goto l_0x1011_b63d; /* jmp 0x1011b63d */
        l_0x1011_b636:
            ii(0x1011_b636, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1011_b63d:
            ii(0x1011_b63d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b640, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_b643, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b646, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_b648, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_b649, 1); popd(edi);                              /* pop edi */
            ii(0x1011_b64a, 1); popd(esi);                              /* pop esi */
            ii(0x1011_b64b, 1); popd(edx);                              /* pop edx */
            ii(0x1011_b64c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_b64d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_b64e, 1); retd(); return;                         /* ret */
        }
    }
}
