using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3c73-507f8ffd")]
        public void Method_1012_3c73()
        {
            ii(0x1012_3c73, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_3c78, 5); call(Definitions.sys_check_available_stack_size, 0x4_20d5); /* call 0x10165d52 */
            ii(0x1012_3c7d, 1); push(ebx);                              /* push ebx */
            ii(0x1012_3c7e, 1); push(esi);                              /* push esi */
            ii(0x1012_3c7f, 1); push(edi);                              /* push edi */
            ii(0x1012_3c80, 1); push(ebp);                              /* push ebp */
            ii(0x1012_3c81, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_3c83, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_3c89, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_3c90, 4); cmp(memd[ss, ebp + 0x20], 0);           /* cmp dword [ebp+0x20], 0x0 */
            ii(0x1012_3c94, 2); if(jz(0x1012_3ca4, 0xe)) goto l_0x1012_3ca4; /* jz 0x10123ca4 */
            ii(0x1012_3c96, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3c99, 6); mov(eax, memd[ds, eax + 0xa0]);         /* mov eax, [eax+0xa0] */
            ii(0x1012_3c9f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_3ca2, 2); jmp(0x1012_3cb0, 0xc); goto l_0x1012_3cb0; /* jmp 0x10123cb0 */
        l_0x1012_3ca4:
            ii(0x1012_3ca4, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3ca7, 6); mov(eax, memd[ds, eax + 0xa8]);         /* mov eax, [eax+0xa8] */
            ii(0x1012_3cad, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1012_3cb0:
            ii(0x1012_3cb0, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_3cb3, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1012_3cb6, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1012_3cb9, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1012_3cbd, 2); if(jz(0x1012_3cc7, 8)) goto l_0x1012_3cc7; /* jz 0x10123cc7 */
            ii(0x1012_3cbf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3cc2, 3); cmp(memb[ds, eax], 0x5b);               /* cmp byte [eax], 0x5b */
            ii(0x1012_3cc5, 2); if(jnz(0x1012_3cc9, 2)) goto l_0x1012_3cc9; /* jnz 0x10123cc9 */
        l_0x1012_3cc7:
            ii(0x1012_3cc7, 2); jmp(0x1012_3cd8, 0xf); goto l_0x1012_3cd8; /* jmp 0x10123cd8 */
        l_0x1012_3cc9:
            ii(0x1012_3cc9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3ccc, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3cce, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_3cd3, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1012_3cd6, 2); if(jnz(0x1012_3ce4, 0xc)) goto l_0x1012_3ce4; /* jnz 0x10123ce4 */
        l_0x1012_3cd8:
            ii(0x1012_3cd8, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_3cdf, 5); jmp(0x1012_3d78, 0x94); goto l_0x1012_3d78; /* jmp 0x10123d78 */
        l_0x1012_3ce4:
            ii(0x1012_3ce4, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3ce7, 6); mov(edx, memd[ds, eax + 0x84]);         /* mov edx, [eax+0x84] */
            ii(0x1012_3ced, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3cf0, 6); mov(eax, memd[ds, eax + 0x88]);         /* mov eax, [eax+0x88] */
            ii(0x1012_3cf6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_3cf8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_3cfb, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
        l_0x1012_3d02:
            ii(0x1012_3d02, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3d05, 3); cmp(memb[ds, eax], 0x20);               /* cmp byte [eax], 0x20 */
            ii(0x1012_3d08, 2); if(jnz(0x1012_3d12, 8)) goto l_0x1012_3d12; /* jnz 0x10123d12 */
            ii(0x1012_3d0a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3d0d, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
            ii(0x1012_3d10, 2); jmp(0x1012_3d02, -0x10); goto l_0x1012_3d02; /* jmp 0x10123d02 */
        l_0x1012_3d12:
            ii(0x1012_3d12, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3d15, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3d17, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_3d1c, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1012_3d1f, 2); if(jz(0x1012_3d2a, 9)) goto l_0x1012_3d2a; /* jz 0x10123d2a */
            ii(0x1012_3d21, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_3d24, 1); dec(eax);                               /* dec eax */
            ii(0x1012_3d25, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1012_3d28, 2); if(ja(0x1012_3d2c, 2)) goto l_0x1012_3d2c; /* ja 0x10123d2c */
        l_0x1012_3d2a:
            ii(0x1012_3d2a, 2); jmp(0x1012_3d41, 0x15); goto l_0x1012_3d41; /* jmp 0x10123d41 */
        l_0x1012_3d2c:
            ii(0x1012_3d2c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3d2f, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
            ii(0x1012_3d32, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_3d35, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
            ii(0x1012_3d38, 3); add(edx, memd[ss, ebp + 0x18]);         /* add edx, [ebp+0x18] */
            ii(0x1012_3d3b, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3d3d, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1012_3d3f, 2); jmp(0x1012_3d12, -0x2f); goto l_0x1012_3d12; /* jmp 0x10123d12 */
        l_0x1012_3d41:
            ii(0x1012_3d41, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_3d44, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1012_3d47, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1012_3d4a, 4); add(memd[ss, ebp - 0xc], 2);            /* add dword [ebp-0xc], 0x2 */
            ii(0x1012_3d4e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3d51, 3); cmp(eax, memd[ss, ebp - 8]);            /* cmp eax, [ebp-0x8] */
            ii(0x1012_3d54, 2); if(jb(0x1012_3d65, 0xf)) goto l_0x1012_3d65; /* jb 0x10123d65 */
            ii(0x1012_3d56, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3d59, 10); mov(memd[ds, eax + 0xa8], 0);          /* mov dword [eax+0xa8], 0x0 */
            ii(0x1012_3d63, 2); jmp(0x1012_3d71, 0xc); goto l_0x1012_3d71; /* jmp 0x10123d71 */
        l_0x1012_3d65:
            ii(0x1012_3d65, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3d68, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_3d6b, 6); mov(memd[ds, edx + 0xa8], eax);         /* mov [edx+0xa8], eax */
        l_0x1012_3d71:
            ii(0x1012_3d71, 7); mov(memd[ss, ebp - 0x10], 1);           /* mov dword [ebp-0x10], 0x1 */
        l_0x1012_3d78:
            ii(0x1012_3d78, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_3d7b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_3d7d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_3d7e, 1); pop(edi);                               /* pop edi */
            ii(0x1012_3d7f, 1); pop(esi);                               /* pop esi */
            ii(0x1012_3d80, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_3d81, 1); ret();                                  /* ret */
        }
    }
}
