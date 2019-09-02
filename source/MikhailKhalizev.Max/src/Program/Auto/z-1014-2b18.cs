using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2b18-e888a8b3")]
        public void Method_1014_2b18()
        {
            ii(0x1014_2b18, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_2b1d, 5); call(Definitions.sys_check_available_stack_size, 0x2_3230); /* call 0x10165d52 */
            ii(0x1014_2b22, 1); push(esi);                              /* push esi */
            ii(0x1014_2b23, 1); push(edi);                              /* push edi */
            ii(0x1014_2b24, 1); push(ebp);                              /* push ebp */
            ii(0x1014_2b25, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2b27, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1014_2b2d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_2b30, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x1014_2b33, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_2b36, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1014_2b39, 4); movsx(eax, memw[ss, ebp + 0x20]);       /* movsx eax, word [ebp+0x20] */
            ii(0x1014_2b3d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_2b43, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1014_2b48, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_2b4a, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1014_2b4d, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1014_2b50, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1014_2b55, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1014_2b58, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1014_2b5d, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1014_2b60, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1014_2b65, 5); cmp(memw[ss, ebp + 0x1c], 0);           /* cmp word [ebp+0x1c], 0x0 */
            ii(0x1014_2b6a, 2); if(jz(0x1014_2b75, 9)) goto l_0x1014_2b75; /* jz 0x10142b75 */
            ii(0x1014_2b6c, 7); mov(memd[ss, ebp - 0x20], 0xffff);      /* mov dword [ebp-0x20], 0xffff */
            ii(0x1014_2b73, 2); jmp(0x1014_2b7c, 7); goto l_0x1014_2b7c; /* jmp 0x10142b7c */
        l_0x1014_2b75:
            ii(0x1014_2b75, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1014_2b7c:
            ii(0x1014_2b7c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_2b7f, 6); mov(eax, memd[ds, eax + 0xfa]);         /* mov eax, [eax+0xfa] */
            ii(0x1014_2b85, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1014_2b88, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_2b8d, 3); or(eax, memd[ss, ebp - 0x20]);          /* or eax, [ebp-0x20] */
            ii(0x1014_2b90, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_2b93, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_2b96, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_2b99, 2); jmp(0x1014_2ba1, 6); goto l_0x1014_2ba1; /* jmp 0x10142ba1 */
        l_0x1014_2b9b:
            ii(0x1014_2b9b, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_2b9e, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1014_2ba1:
            ii(0x1014_2ba1, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x1014_2ba7, 1); dec(eax);                               /* dec eax */
            ii(0x1014_2ba8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_2bab, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_2bae, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1014_2bb1, 1); cwde();                                 /* cwde */
            ii(0x1014_2bb2, 5); call(Definitions.my_min, -0xb_9433);    /* call 0x10089784 */
            ii(0x1014_2bb7, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1014_2bbb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_2bbd, 6); if(jg(0x1014_2cc4, 0x101)) goto l_0x1014_2cc4; /* jg 0x10142cc4 */
            ii(0x1014_2bc3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_2bc6, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1014_2bc9, 2); jmp(0x1014_2bd1, 6); goto l_0x1014_2bd1; /* jmp 0x10142bd1 */
        l_0x1014_2bcb:
            ii(0x1014_2bcb, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1014_2bce, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
        l_0x1014_2bd1:
            ii(0x1014_2bd1, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x1014_2bd7, 1); dec(eax);                               /* dec eax */
            ii(0x1014_2bd8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_2bdb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_2bde, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1014_2be1, 1); cwde();                                 /* cwde */
            ii(0x1014_2be2, 5); call(Definitions.my_min, -0xb_9463);    /* call 0x10089784 */
            ii(0x1014_2be7, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1014_2beb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_2bed, 6); if(jg(0x1014_2cbf, 0xcc)) goto l_0x1014_2cbf; /* jg 0x10142cbf */
            ii(0x1014_2bf3, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1014_2bf7, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1014_2bfc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2bff, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_2c02, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1014_2c06, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2c08, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_2c0a, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x1014_2c10, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2c12, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1014_2c15, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_2c18, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1014_2c1c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_2c1e, 4); mov(ax, memw[ss, ebp - 0x14]);          /* mov ax, [ebp-0x14] */
            ii(0x1014_2c22, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1014_2c24, 2); if(jz(0x1014_2c53, 0x2d)) goto l_0x1014_2c53; /* jz 0x10142c53 */
            ii(0x1014_2c26, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1014_2c2a, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1014_2c2e, 5); call(0x1007_3d48, -0xc_eeeb);           /* call 0x10073d48 */
            ii(0x1014_2c33, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_2c38, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1014_2c3b, 2); if(jz(0x1014_2c46, 9)) goto l_0x1014_2c46; /* jz 0x10142c46 */
            ii(0x1014_2c3d, 7); mov(memd[ss, ebp - 0x2c], 1);           /* mov dword [ebp-0x2c], 0x1 */
            ii(0x1014_2c44, 2); jmp(0x1014_2c4d, 7); goto l_0x1014_2c4d; /* jmp 0x10142c4d */
        l_0x1014_2c46:
            ii(0x1014_2c46, 7); mov(memd[ss, ebp - 0x2c], 0);           /* mov dword [ebp-0x2c], 0x0 */
        l_0x1014_2c4d:
            ii(0x1014_2c4d, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1014_2c51, 2); if(jnz(0x1014_2c55, 2)) goto l_0x1014_2c55; /* jnz 0x10142c55 */
        l_0x1014_2c53:
            ii(0x1014_2c53, 2); jmp(0x1014_2cba, 0x65); goto l_0x1014_2cba; /* jmp 0x10142cba */
        l_0x1014_2c55:
            ii(0x1014_2c55, 6); test(memw[ss, ebp - 0x18], 0x40);       /* test word [ebp-0x18], 0x40 */
            ii(0x1014_2c5b, 2); if(jz(0x1014_2c7a, 0x1d)) goto l_0x1014_2c7a; /* jz 0x10142c7a */
            ii(0x1014_2c5d, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_2c62, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_2c65, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1014_2c6a, 1); cwde();                                 /* cwde */
            ii(0x1014_2c6b, 5); call(Definitions.my_min, -0xb_94ec);    /* call 0x10089784 */
            ii(0x1014_2c70, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_2c72, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1014_2c75, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x1014_2c78, 2); jmp(0x1014_2cba, 0x40); goto l_0x1014_2cba; /* jmp 0x10142cba */
        l_0x1014_2c7a:
            ii(0x1014_2c7a, 6); test(memw[ss, ebp - 0x18], 0x20);       /* test word [ebp-0x18], 0x20 */
            ii(0x1014_2c80, 2); if(jz(0x1014_2c9f, 0x1d)) goto l_0x1014_2c9f; /* jz 0x10142c9f */
            ii(0x1014_2c82, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_2c87, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_2c8a, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1014_2c8f, 1); cwde();                                 /* cwde */
            ii(0x1014_2c90, 5); call(Definitions.my_min, -0xb_9511);    /* call 0x10089784 */
            ii(0x1014_2c95, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_2c97, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1014_2c9a, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x1014_2c9d, 2); jmp(0x1014_2cba, 0x1b); goto l_0x1014_2cba; /* jmp 0x10142cba */
        l_0x1014_2c9f:
            ii(0x1014_2c9f, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_2ca4, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_2ca7, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1014_2cac, 1); cwde();                                 /* cwde */
            ii(0x1014_2cad, 5); call(Definitions.my_min, -0xb_952e);    /* call 0x10089784 */
            ii(0x1014_2cb2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_2cb4, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1014_2cb7, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
        l_0x1014_2cba:
            ii(0x1014_2cba, 5); jmp(0x1014_2bcb, -0xf4); goto l_0x1014_2bcb; /* jmp 0x10142bcb */
        l_0x1014_2cbf:
            ii(0x1014_2cbf, 5); jmp(0x1014_2b9b, -0x129); goto l_0x1014_2b9b; /* jmp 0x10142b9b */
        l_0x1014_2cc4:
            ii(0x1014_2cc4, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1014_2cc7, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1014_2cca, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1014_2cce, 2); if(jle(0x1014_2cd9, 9)) goto l_0x1014_2cd9; /* jle 0x10142cd9 */
            ii(0x1014_2cd0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_2cd3, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1014_2cd6, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
        l_0x1014_2cd9:
            ii(0x1014_2cd9, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1014_2cdc, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1014_2cdf, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1014_2ce3, 2); if(jle(0x1014_2cee, 9)) goto l_0x1014_2cee; /* jle 0x10142cee */
            ii(0x1014_2ce5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_2ce8, 3); mov(edx, memd[ss, ebp + 0x18]);         /* mov edx, [ebp+0x18] */
            ii(0x1014_2ceb, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
        l_0x1014_2cee:
            ii(0x1014_2cee, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1014_2cf1, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1014_2cf4, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1014_2cf8, 2); if(jle(0x1014_2d03, 9)) goto l_0x1014_2d03; /* jle 0x10142d03 */
            ii(0x1014_2cfa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_2cfd, 3); mov(edx, memd[ss, ebp + 0x10]);         /* mov edx, [ebp+0x10] */
            ii(0x1014_2d00, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
        l_0x1014_2d03:
            ii(0x1014_2d03, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2d05, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_2d06, 1); pop(edi);                               /* pop edi */
            ii(0x1014_2d07, 1); pop(esi);                               /* pop esi */
            ii(0x1014_2d08, 3); ret(0x14);                              /* ret 0x14 */
        }
    }
}
