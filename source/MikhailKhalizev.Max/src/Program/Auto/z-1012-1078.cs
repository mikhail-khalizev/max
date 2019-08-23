using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_1078-f1c970ce")]
        public void Method_1012_1078()
        {
            ii(0x1012_1078, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_107d, 5); calld(Definitions.sys_check_available_stack_size, 0x4_4cd0); /* call 0x10165d52 */
            ii(0x1012_1082, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_1083, 1); pushd(esi);                             /* push esi */
            ii(0x1012_1084, 1); pushd(edi);                             /* push edi */
            ii(0x1012_1085, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_1086, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_1088, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_108e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_1091, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_1094, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1012_1097, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_109b, 2); if(jnzd(0x1012_10ae, 0x11)) goto l_0x1012_10ae; /* jnz 0x101210ae */
            ii(0x1012_109d, 4); movsx(ecx, memb_a32[ss, ebp - 0x4]);    /* movsx ecx, byte [ebp-0x4] */
            ii(0x1012_10a1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_10a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_10a5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_10a7, 5); calld(0x1012_0ecd, -0x1df);             /* call 0x10120ecd */
            ii(0x1012_10ac, 2); jmpd(0x1012_10e0, 0x32); goto l_0x1012_10e0; /* jmp 0x101210e0 */
        l_0x1012_10ae:
            ii(0x1012_10ae, 4); movsx(ecx, memb_a32[ss, ebp - 0x4]);    /* movsx ecx, byte [ebp-0x4] */
            ii(0x1012_10b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_10b5, 5); calld(0x1007_623c, -0xa_ae7e);          /* call 0x1007623c */
            ii(0x1012_10ba, 3); mov(esi, memd_a32[ds, eax + 0x8]);      /* mov esi, [eax+0x8] */
            ii(0x1012_10bd, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1012_10c0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_10c2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_10c5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_10c8, 5); calld(0x1015_d211, 0x3_c144);           /* call 0x1015d211 */
            ii(0x1012_10cd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_10d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_10d3, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1012_10d6, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_10d8, 1); cwde();                                 /* cwde */
            ii(0x1012_10d9, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1012_10db, 5); calld(0x1012_0ecd, -0x213);             /* call 0x10120ecd */
        l_0x1012_10e0:
            ii(0x1012_10e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_10e2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_10e3, 1); popd(edi);                              /* pop edi */
            ii(0x1012_10e4, 1); popd(esi);                              /* pop esi */
            ii(0x1012_10e5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_10e6, 1); retd();                                 /* ret */
        }
    }
}
