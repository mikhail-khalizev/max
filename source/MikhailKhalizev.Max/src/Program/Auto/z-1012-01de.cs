using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("02228b33-5e3b-4991-935f-b6ae56f15550")]
        public void Method_1012_01de()
        {
            ii(0x1012_01de, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_01e3, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5b6a); /* call 0x10165d52 */
            ii(0x1012_01e8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_01e9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_01ea, 1); pushd(edi);                             /* push edi */
            ii(0x1012_01eb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_01ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_01ee, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_01f4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_01f7, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_01fa, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1012_01fd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0200, 4); cmp(memb_a32[ds, eax + 0x6], 0);        /* cmp byte [eax+0x6], 0x0 */
            ii(0x1012_0204, 2); if(jnzd(0x1012_021b, 0x15)) goto l_0x1012_021b; /* jnz 0x1012021b */
            ii(0x1012_0206, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_0209, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_020c, 5); calld(0x1007_5e64, -0xa_a3ad);          /* call 0x10075e64 */
            ii(0x1012_0211, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_0213, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0216, 5); calld(0x1011_ff4c, -0x2cf);             /* call 0x1011ff4c */
        l_0x1012_021b:
            ii(0x1012_021b, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_021f, 2); if(jzd(0x1012_023e, 0x1d)) goto l_0x1012_023e; /* jz 0x1012023e */
            ii(0x1012_0221, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0224, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1012_0226, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_0229, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_022c, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1012_022f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0232, 5); calld(0x1008_a728, -0x9_5b0f);          /* call 0x1008a728 */
            ii(0x1012_0237, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_0239, 3); mov(memb_a32[ds, eax], 0x20);           /* mov byte [eax], 0x20 */
            ii(0x1012_023c, 2); jmpd(0x1012_0259, 0x1b); goto l_0x1012_0259; /* jmp 0x10120259 */
        l_0x1012_023e:
            ii(0x1012_023e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0241, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1012_0243, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_0246, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0249, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1012_024c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_024f, 5); calld(0x1008_a728, -0x9_5b2c);          /* call 0x1008a728 */
            ii(0x1012_0254, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_0256, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x1012_0259:
            ii(0x1012_0259, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_025b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_025c, 1); popd(edi);                              /* pop edi */
            ii(0x1012_025d, 1); popd(esi);                              /* pop esi */
            ii(0x1012_025e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_025f, 1); retd(); return;                         /* ret */
        }
    }
}
