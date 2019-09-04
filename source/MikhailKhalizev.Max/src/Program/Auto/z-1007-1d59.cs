using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1d59-9ce249df")]
        public void Method_1007_1d59()
        {
            ii(0x1007_1d59, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_1d5e, 5); call(Definitions.sys_check_available_stack_size, 0xf_3fef); /* call 0x10165d52 */
            ii(0x1007_1d63, 1); push(ecx);                              /* push ecx */
            ii(0x1007_1d64, 1); push(esi);                              /* push esi */
            ii(0x1007_1d65, 1); push(edi);                              /* push edi */
            ii(0x1007_1d66, 1); push(ebp);                              /* push ebp */
            ii(0x1007_1d67, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1d69, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_1d6f, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_1d72, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1007_1d75, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1007_1d78, 7); mov(memd[ss, ebp - 16], 0x3100);        /* mov dword [ebp-0x10], 0x3100 */
            ii(0x1007_1d7f, 4); movsx(ebx, memw[ss, ebp - 16]);         /* movsx ebx, word [ebp-0x10] */
            ii(0x1007_1d83, 6); mov(edx, memd[ds, 0x101c_70e8]);        /* mov edx, [0x101c70e8] */
            ii(0x1007_1d89, 5); mov(eax, memd[ds, 0x101c_70e0]);        /* mov eax, [0x101c70e0] */
            ii(0x1007_1d8e, 5); call(Definitions.sys_memcpy, 0xf_40b8); /* call 0x10165e4b */
            ii(0x1007_1d93, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_1d97, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1d99, 2); if(jnz(0x1007_1df9, 0x5e)) goto l_0x1007_1df9; /* jnz 0x10071df9 */
        l_0x1007_1d9b:
            ii(0x1007_1d9b, 3); dec(memd[ss, ebp - 16]);                /* dec dword [ebp-0x10] */
            ii(0x1007_1d9e, 5); cmp(memw[ss, ebp - 16], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1007_1da3, 2); if(jz(0x1007_1df9, 0x54)) goto l_0x1007_1df9; /* jz 0x10071df9 */
            ii(0x1007_1da5, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1007_1da9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1daf, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x1007_1db3, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1007_1db9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_1dbb, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_1dbd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1dc2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1dc4, 2); if(jz(0x1007_1dcc, 6)) goto l_0x1007_1dcc; /* jz 0x10071dcc */
            ii(0x1007_1dc6, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_1dca, 2); if(jz(0x1007_1df7, 0x2b)) goto l_0x1007_1df7; /* jz 0x10071df7 */
        l_0x1007_1dcc:
            ii(0x1007_1dcc, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1007_1dd0, 6); mov(edx, memd[ds, 0x101c_70e0]);        /* mov edx, [0x101c70e0] */
            ii(0x1007_1dd6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_1dd8, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_1dda, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1ddf, 6); mov(edx, memd[ds, 0x101c_70cc]);        /* mov edx, [0x101c70cc] */
            ii(0x1007_1de5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_1de7, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1007_1deb, 6); mov(ebx, memd[ds, 0x101c_70e0]);        /* mov ebx, [0x101c70e0] */
            ii(0x1007_1df1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_1df3, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1007_1df5, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
        l_0x1007_1df7:
            ii(0x1007_1df7, 2); jmp(0x1007_1d9b, -0x5e); goto l_0x1007_1d9b; /* jmp 0x10071d9b */
        l_0x1007_1df9:
            ii(0x1007_1df9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1dfb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_1dfc, 1); pop(edi);                               /* pop edi */
            ii(0x1007_1dfd, 1); pop(esi);                               /* pop esi */
            ii(0x1007_1dfe, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_1dff, 1); ret();                                  /* ret */
        }
    }
}
