using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9c68-3baf1163")]
        public void Method_100e_9c68()
        {
            ii(0x100e_9c68, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_9c6d, 5); calld(Definitions.sys_check_available_stack_size, 0x7_c0e0); /* call 0x10165d52 */
            ii(0x100e_9c72, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_9c73, 1); pushd(esi);                             /* push esi */
            ii(0x100e_9c74, 1); pushd(edi);                             /* push edi */
            ii(0x100e_9c75, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_9c76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_9c78, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_9c7e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_9c81, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_9c84, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_9c87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9c8a, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_9c8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9c8f, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x100e_9c91, 2); if(jled(0x100e_9c9f, 0xc)) goto l_0x100e_9c9f; /* jle 0x100e9c9f */
            ii(0x100e_9c93, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9c96, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_9c98, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9c9b, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100e_9c9d, 2); jmpd(0x100e_9ca9, 0xa); goto l_0x100e_9ca9; /* jmp 0x100e9ca9 */
        l_0x100e_9c9f:
            ii(0x100e_9c9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9ca2, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_9ca4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9ca7, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
        l_0x100e_9ca9:
            ii(0x100e_9ca9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9cac, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100e_9caf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9cb2, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x100e_9cb5, 2); if(jled(0x100e_9cc5, 0xe)) goto l_0x100e_9cc5; /* jle 0x100e9cc5 */
            ii(0x100e_9cb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9cba, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100e_9cbd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9cc0, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100e_9cc3, 2); jmpd(0x100e_9cd1, 0xc); goto l_0x100e_9cd1; /* jmp 0x100e9cd1 */
        l_0x100e_9cc5:
            ii(0x100e_9cc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9cc8, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100e_9ccb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9cce, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
        l_0x100e_9cd1:
            ii(0x100e_9cd1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9cd4, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100e_9cd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9cda, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x100e_9cdd, 2); if(jged(0x100e_9ced, 0xe)) goto l_0x100e_9ced; /* jge 0x100e9ced */
            ii(0x100e_9cdf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9ce2, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100e_9ce5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9ce8, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x100e_9ceb, 2); jmpd(0x100e_9cf9, 0xc); goto l_0x100e_9cf9; /* jmp 0x100e9cf9 */
        l_0x100e_9ced:
            ii(0x100e_9ced, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9cf0, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100e_9cf3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9cf6, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
        l_0x100e_9cf9:
            ii(0x100e_9cf9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9cfc, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100e_9cff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9d02, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x100e_9d05, 2); if(jged(0x100e_9d15, 0xe)) goto l_0x100e_9d15; /* jge 0x100e9d15 */
            ii(0x100e_9d07, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9d0a, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100e_9d0d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9d10, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x100e_9d13, 2); jmpd(0x100e_9d21, 0xc); goto l_0x100e_9d21; /* jmp 0x100e9d21 */
        l_0x100e_9d15:
            ii(0x100e_9d15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9d18, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100e_9d1b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9d1e, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
        l_0x100e_9d21:
            ii(0x100e_9d21, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9d24, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100e_9d27, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9d2a, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x100e_9d2c, 2); if(jled(0x100e_9d3c, 0xe)) goto l_0x100e_9d3c; /* jle 0x100e9d3c */
            ii(0x100e_9d2e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9d31, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100e_9d34, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9d37, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x100e_9d3a, 2); if(jgd(0x100e_9d3e, 0x2)) goto l_0x100e_9d3e; /* jg 0x100e9d3e */
        l_0x100e_9d3c:
            ii(0x100e_9d3c, 2); jmpd(0x100e_9d44, 0x6); goto l_0x100e_9d44; /* jmp 0x100e9d44 */
        l_0x100e_9d3e:
            ii(0x100e_9d3e, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100e_9d42, 2); jmpd(0x100e_9d48, 0x4); goto l_0x100e_9d48; /* jmp 0x100e9d48 */
        l_0x100e_9d44:
            ii(0x100e_9d44, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x100e_9d48:
            ii(0x100e_9d48, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_9d4b, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100e_9d4e, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100e_9d51, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9d53, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_9d54, 1); popd(edi);                              /* pop edi */
            ii(0x100e_9d55, 1); popd(esi);                              /* pop esi */
            ii(0x100e_9d56, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_9d57, 1); retd(); return;                         /* ret */
        }
    }
}
