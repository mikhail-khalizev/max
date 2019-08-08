using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13346442-560c-4793-94bc-ff8d9f269944")]
        public void Method_1012_29ad()
        {
            ii(0x1012_29ad, 5); pushd(0xa0);                            /* push 0xa0 */
            ii(0x1012_29b2, 5); calld(Definitions.sys_check_available_stack_size, 0x4_339b); /* call 0x10165d52 */
            ii(0x1012_29b7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_29b8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_29b9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_29ba, 1); pushd(edi);                             /* push edi */
            ii(0x1012_29bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_29bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_29be, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1012_29c4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_29c7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_29ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_29cd, 4); cmp(memb_a32[ds, eax + 0x48], 0);       /* cmp byte [eax+0x48], 0x0 */
            ii(0x1012_29d1, 2); if(jzd(0x1012_2a0d, 0x3a)) goto l_0x1012_2a0d; /* jz 0x10122a0d */
            ii(0x1012_29d3, 5); calld(/* sys */ 0x1016_c348, 0x4_9970); /* call 0x1016c348 */
            ii(0x1012_29d8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_29db, 7); test(memd_a32[ss, ebp - 0x14], 0x10);   /* test dword [ebp-0x14], 0x10 */
            ii(0x1012_29e2, 2); if(jnzd(0x1012_29ea, 0x6)) goto l_0x1012_29ea; /* jnz 0x101229ea */
            ii(0x1012_29e4, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1012_29e8, 2); if(jnzd(0x1012_29fc, 0x12)) goto l_0x1012_29fc; /* jnz 0x101229fc */
        l_0x1012_29ea:
            ii(0x1012_29ea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_29ed, 4); mov(memb_a32[ds, eax + 0x48], 0);       /* mov byte [eax+0x48], 0x0 */
            ii(0x1012_29f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_29f4, 6); mov(memw_a32[ds, eax + 0x46], 0);       /* mov word [eax+0x46], 0x0 */
            ii(0x1012_29fa, 2); jmpd(0x1012_2a0d, 0x11); goto l_0x1012_2a0d; /* jmp 0x10122a0d */
        l_0x1012_29fc:
            ii(0x1012_29fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_29ff, 3); mov(edx, memd_a32[ds, eax + 0x44]);     /* mov edx, [eax+0x44] */
            ii(0x1012_2a02, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_2a05, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2a08, 5); calld(0x1012_25ae, -0x45f);             /* call 0x101225ae */
        l_0x1012_2a0d:
            ii(0x1012_2a0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_2a10, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_2a13, 5); if(jmpd_func(0x1012_3160, 0x748)) return; /* jmp 0x10123160 */
        }
    }
}
