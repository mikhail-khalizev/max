using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4b2b-ec4a8b88")]
        public void Method_1007_4b2b()
        {
            ii(0x1007_4b2b, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1007_4b30, 5); calld(Definitions.sys_check_available_stack_size, 0xf_121d); /* call 0x10165d52 */
            ii(0x1007_4b35, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_4b36, 1); pushd(esi);                             /* push esi */
            ii(0x1007_4b37, 1); pushd(edi);                             /* push edi */
            ii(0x1007_4b38, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_4b39, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4b3b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_4b41, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_4b44, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_4b47, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_4b4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4b4d, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1007_4b50, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_4b53, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4b56, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1007_4b5a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_4b5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4b60, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1007_4b64, 2); if(jzd(0x1007_4b75, 0xf)) goto l_0x1007_4b75; /* jz 0x10074b75 */
            ii(0x1007_4b66, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4b69, 4); test(memb_a32[ds, eax + 0x14], 0x1);    /* test byte [eax+0x14], 0x1 */
            ii(0x1007_4b6d, 2); if(jnzd(0x1007_4b75, 0x6)) goto l_0x1007_4b75; /* jnz 0x10074b75 */
            ii(0x1007_4b6f, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_4b73, 2); jmpd(0x1007_4bd4, 0x5f); goto l_0x1007_4bd4; /* jmp 0x10074bd4 */
        l_0x1007_4b75:
            ii(0x1007_4b75, 7); test(memd_a32[ss, ebp - 0x1c], 0x40);   /* test dword [ebp-0x1c], 0x40 */
            ii(0x1007_4b7c, 2); if(jzd(0x1007_4b92, 0x14)) goto l_0x1007_4b92; /* jz 0x10074b92 */
            ii(0x1007_4b7e, 7); test(memd_a32[ss, ebp - 0x1c], 0x1_0000); /* test dword [ebp-0x1c], 0x10000 */
            ii(0x1007_4b85, 2); if(jnzd(0x1007_4b92, 0xb)) goto l_0x1007_4b92; /* jnz 0x10074b92 */
            ii(0x1007_4b87, 4); and(memd_a32[ss, ebp - 0x1c], -0x41 /* 0xbf */); /* and dword [ebp-0x1c], 0xffffffbf */
            ii(0x1007_4b8b, 7); or(memd_a32[ss, ebp - 0x1c], 0x100);    /* or dword [ebp-0x1c], 0x100 */
        l_0x1007_4b92:
            ii(0x1007_4b92, 5); cmp(memw_a32[ss, ebp - 0x14], 0xf);     /* cmp word [ebp-0x14], 0xf */
            ii(0x1007_4b97, 2); if(jzd(0x1007_4ba0, 0x7)) goto l_0x1007_4ba0; /* jz 0x10074ba0 */
            ii(0x1007_4b99, 5); cmp(memw_a32[ss, ebp - 0x14], 0x10);    /* cmp word [ebp-0x14], 0x10 */
            ii(0x1007_4b9e, 2); if(jnzd(0x1007_4baf, 0xf)) goto l_0x1007_4baf; /* jnz 0x10074baf */
        l_0x1007_4ba0:
            ii(0x1007_4ba0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4ba3, 5); calld(0x1007_611c, 0x1574);             /* call 0x1007611c */
            ii(0x1007_4ba8, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1007_4bac, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1007_4baf:
            ii(0x1007_4baf, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_4bb2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_4bb5, 5); calld(0x1007_5e64, 0x12aa);             /* call 0x10075e64 */
            ii(0x1007_4bba, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1007_4bbc, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x1007_4bbf, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1007_4bc3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4bc6, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1007_4bc9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_4bcc, 5); calld(0x1007_4955, -0x27c);             /* call 0x10074955 */
            ii(0x1007_4bd1, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
        l_0x1007_4bd4:
            ii(0x1007_4bd4, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_4bd7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4bd9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4bda, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4bdb, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4bdc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_4bdd, 1); retd(); return;                         /* ret */
        }
    }
}
