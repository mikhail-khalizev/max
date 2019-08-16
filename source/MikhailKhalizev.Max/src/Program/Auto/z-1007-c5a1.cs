using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("916007fe-3010-4abd-982a-f4aa7ccc388c")]
        public void Method_1007_c5a1()
        {
            ii(0x1007_c5a1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_c5a6, 5); calld(Definitions.sys_check_available_stack_size, 0xe_97a7); /* call 0x10165d52 */
            ii(0x1007_c5ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_c5ac, 1); pushd(esi);                             /* push esi */
            ii(0x1007_c5ad, 1); pushd(edi);                             /* push edi */
            ii(0x1007_c5ae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_c5af, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_c5b1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_c5b7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_c5ba, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_c5bd, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1007_c5c0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_c5c3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_c5c6, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_c5ca, 2); if(jnzd(0x1007_c5e0, 0x14)) goto l_0x1007_c5e0; /* jnz 0x1007c5e0 */
            ii(0x1007_c5cc, 5); mov(ebx, 0x1007_c5a1);                  /* mov ebx, 0x1007c5a1 */
            ii(0x1007_c5d1, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_c5d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_c5d7, 5); calld(0x1007_8d4a, -0x3892);            /* call 0x10078d4a */
            ii(0x1007_c5dc, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c5de, 2); if(jnzd(0x1007_c5eb, 0xb)) goto l_0x1007_c5eb; /* jnz 0x1007c5eb */
        l_0x1007_c5e0:
            ii(0x1007_c5e0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_c5e3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_c5e6, 5); calld(0x1007_c5f2, 0x7);                /* call 0x1007c5f2 */
        l_0x1007_c5eb:
            ii(0x1007_c5eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_c5ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_c5ee, 1); popd(edi);                              /* pop edi */
            ii(0x1007_c5ef, 1); popd(esi);                              /* pop esi */
            ii(0x1007_c5f0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_c5f1, 1); retd(); return;                         /* ret */
        }
    }
}