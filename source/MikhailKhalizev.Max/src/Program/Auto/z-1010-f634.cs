using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("18873de5-4782-4426-a2ca-6dbf7066ce36")]
        public void Method_1010_f634()
        {
            ii(0x1010_f634, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_f639, 5); calld(Definitions.sys_check_available_stack_size, 0x5_6714); /* call 0x10165d52 */
            ii(0x1010_f63e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f63f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f640, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f641, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f642, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f643, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f644, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f646, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_f64c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f64f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f652, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1010_f656, 6); sub(eax, 0x7d0);                        /* sub eax, 0x7d0 */
            ii(0x1010_f65c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_f65f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f663, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f666, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f669, 6); mov(eax, memd_a32[ds, eax + 0x1d9]);    /* mov eax, [eax+0x1d9] */
            ii(0x1010_f66f, 5); calld(0x100c_fbbe, -0x3_fab6);          /* call 0x100cfbbe */
            ii(0x1010_f674, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f677, 6); mov(eax, memd_a32[ds, eax + 0x227]);    /* mov eax, [eax+0x227] */
            ii(0x1010_f67d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_f680, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_f684, 1); dec(eax);                               /* dec eax */
            ii(0x1010_f685, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_f687, 2); if(jged(0x1010_f6b3, 0x2a)) goto l_0x1010_f6b3; /* jge 0x1010f6b3 */
            ii(0x1010_f689, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f68d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f690, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f693, 6); mov(edx, memd_a32[ds, eax + 0x201]);    /* mov edx, [eax+0x201] */
            ii(0x1010_f699, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f69c, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_f69f, 5); calld(0x100e_b14d, -0x2_4557);          /* call 0x100eb14d */
            ii(0x1010_f6a4, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_f6a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f6ac, 5); calld(0x1010_facf, 0x41e);              /* call 0x1010facf */
            ii(0x1010_f6b1, 2); jmpd(0x1010_f6bd, 0xa); goto l_0x1010_f6bd; /* jmp 0x1010f6bd */
        l_0x1010_f6b3:
            ii(0x1010_f6b3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f6b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f6b8, 5); calld(0x1010_facf, 0x412);              /* call 0x1010facf */
        l_0x1010_f6bd:
            ii(0x1010_f6bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f6bf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f6c0, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f6c1, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f6c2, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f6c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f6c4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f6c5, 1); retd(); return;                         /* ret */
        }
    }
}
