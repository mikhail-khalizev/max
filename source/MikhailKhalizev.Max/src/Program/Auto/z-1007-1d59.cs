using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0bae4a87-be96-45fa-b2d4-60690f0be306")]
        public void Method_1007_1d59()
        {
            ii(0x1007_1d59, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_1d5e, 5); calld(Definitions.sys_check_available_stack_size, 0xf3fef); /* call 0x10165d52 */
            ii(0x1007_1d63, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_1d64, 1); pushd(esi);                             /* push esi */
            ii(0x1007_1d65, 1); pushd(edi);                             /* push edi */
            ii(0x1007_1d66, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_1d67, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1d69, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_1d6f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_1d72, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_1d75, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1007_1d78, 7); mov(memd_a32[ss, ebp - 0x10], 0x3100);  /* mov dword [ebp-0x10], 0x3100 */
            ii(0x1007_1d7f, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1007_1d83, 6); mov(edx, memd_a32[ds, 0x101c_70e8]);    /* mov edx, [0x101c70e8] */
            ii(0x1007_1d89, 5); mov(eax, memd_a32[ds, 0x101c_70e0]);    /* mov eax, [0x101c70e0] */
            ii(0x1007_1d8e, 5); calld(Definitions.sys_memcpy, 0xf40b8); /* call 0x10165e4b */
            ii(0x1007_1d93, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_1d97, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1d99, 2); if(jnzd(0x1007_1df9, 0x5e)) goto l_0x1007_1df9; /* jnz 0x10071df9 */
        l_0x1007_1d9b:
            ii(0x1007_1d9b, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1007_1d9e, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1007_1da3, 2); if(jzd(0x1007_1df9, 0x54)) goto l_0x1007_1df9; /* jz 0x10071df9 */
            ii(0x1007_1da5, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_1da9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1daf, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1007_1db3, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x1007_1db9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_1dbb, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1007_1dbd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1dc2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1dc4, 2); if(jzd(0x1007_1dcc, 0x6)) goto l_0x1007_1dcc; /* jz 0x10071dcc */
            ii(0x1007_1dc6, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_1dca, 2); if(jzd(0x1007_1df7, 0x2b)) goto l_0x1007_1df7; /* jz 0x10071df7 */
        l_0x1007_1dcc:
            ii(0x1007_1dcc, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_1dd0, 6); mov(edx, memd_a32[ds, 0x101c_70e0]);    /* mov edx, [0x101c70e0] */
            ii(0x1007_1dd6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_1dd8, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1007_1dda, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1ddf, 6); mov(edx, memd_a32[ds, 0x101c_70cc]);    /* mov edx, [0x101c70cc] */
            ii(0x1007_1de5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_1de7, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_1deb, 6); mov(ebx, memd_a32[ds, 0x101c_70e0]);    /* mov ebx, [0x101c70e0] */
            ii(0x1007_1df1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_1df3, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1007_1df5, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
        l_0x1007_1df7:
            ii(0x1007_1df7, 2); jmpd(0x1007_1d9b, -0x5e); goto l_0x1007_1d9b; /* jmp 0x10071d9b */
        l_0x1007_1df9:
            ii(0x1007_1df9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1dfb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_1dfc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_1dfd, 1); popd(esi);                              /* pop esi */
            ii(0x1007_1dfe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_1dff, 1); retd(); return;                         /* ret */
        }
    }
}
