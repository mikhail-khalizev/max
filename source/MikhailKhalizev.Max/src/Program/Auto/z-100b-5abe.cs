using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5abe-2a5e5ab0")]
        public void Method_100b_5abe()
        {
            ii(0x100b_5abe, 5); push(0x48);                             /* push 0x48 */
            ii(0x100b_5ac3, 5); call(Definitions.sys_check_available_stack_size, 0xb_028a); /* call 0x10165d52 */
            ii(0x100b_5ac8, 1); push(ecx);                              /* push ecx */
            ii(0x100b_5ac9, 1); push(esi);                              /* push esi */
            ii(0x100b_5aca, 1); push(edi);                              /* push edi */
            ii(0x100b_5acb, 1); push(ebp);                              /* push ebp */
            ii(0x100b_5acc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5ace, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100b_5ad4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_5ad7, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_5ada, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100b_5add, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_5ae2, 5); call(0x1007_6338, -0x3_f7af);           /* call 0x10076338 */
            ii(0x100b_5ae7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5ae9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5aec, 5); call(0x1007_64b8, -0x3_f639);           /* call 0x100764b8 */
            ii(0x100b_5af1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5af4, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_f009); /* call 0x10076af0 */
            ii(0x100b_5af9, 2); jmp(0x100b_5b03, 0x8); goto l_0x100b_5b03; /* jmp 0x100b5b03 */
        l_0x100b_5afb:
            ii(0x100b_5afb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5afe, 5); call(0x1007_6bf8, -0x3_ef0b);           /* call 0x10076bf8 */
        l_0x100b_5b03:
            ii(0x100b_5b03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5b05, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b08, 5); call(0x1013_ad71, 0x8_5264);            /* call 0x1013ad71 */
            ii(0x100b_5b0d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_5b0f, 6); if(jz(0x100b_5c85, 0x170)) goto l_0x100b_5c85; /* jz 0x100b5c85 */
            ii(0x100b_5b15, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b18, 5); call(0x1007_63a0, -0x3_f77d);           /* call 0x100763a0 */
            ii(0x100b_5b1d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5b1f, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100b_5b22, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_5b25, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100b_5b28, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_5b2b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_5b2d, 2); if(jnz(0x100b_5b41, 0x12)) goto l_0x100b_5b41; /* jnz 0x100b5b41 */
            ii(0x100b_5b2f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b32, 5); call(0x1007_63a0, -0x3_f797);           /* call 0x100763a0 */
            ii(0x100b_5b37, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x100b_5b3b, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100b_5b3f, 2); if(jz(0x100b_5b43, 0x2)) goto l_0x100b_5b43; /* jz 0x100b5b43 */
        l_0x100b_5b41:
            ii(0x100b_5b41, 2); jmp(0x100b_5b51, 0xe); goto l_0x100b_5b51; /* jmp 0x100b5b51 */
        l_0x100b_5b43:
            ii(0x100b_5b43, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b46, 5); call(0x1007_63a0, -0x3_f7ab);           /* call 0x100763a0 */
            ii(0x100b_5b4b, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_5b4f, 2); if(jnz(0x100b_5b53, 0x2)) goto l_0x100b_5b53; /* jnz 0x100b5b53 */
        l_0x100b_5b51:
            ii(0x100b_5b51, 2); jmp(0x100b_5b77, 0x24); goto l_0x100b_5b77; /* jmp 0x100b5b77 */
        l_0x100b_5b53:
            ii(0x100b_5b53, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b56, 5); call(0x1007_63a0, -0x3_f7bb);           /* call 0x100763a0 */
            ii(0x100b_5b5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5b5d, 3); mov(dl, memb[ds, eax + 0x54]);          /* mov dl, [eax+0x54] */
            ii(0x100b_5b60, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b63, 5); call(0x1007_63a0, -0x3_f7c8);           /* call 0x100763a0 */
            ii(0x100b_5b68, 5); call(0x1007_623c, -0x3_f931);           /* call 0x1007623c */
            ii(0x100b_5b6d, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100b_5b70, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_5b73, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_5b75, 2); if(jg(0x100b_5b79, 0x2)) goto l_0x100b_5b79; /* jg 0x100b5b79 */
        l_0x100b_5b77:
            ii(0x100b_5b77, 2); jmp(0x100b_5b9d, 0x24); goto l_0x100b_5b9d; /* jmp 0x100b5b9d */
        l_0x100b_5b79:
            ii(0x100b_5b79, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b7c, 5); call(0x1007_63a0, -0x3_f7e1);           /* call 0x100763a0 */
            ii(0x100b_5b81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5b83, 3); mov(dl, memb[ds, eax + 0x4d]);          /* mov dl, [eax+0x4d] */
            ii(0x100b_5b86, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5b89, 5); call(0x1007_63a0, -0x3_f7ee);           /* call 0x100763a0 */
            ii(0x100b_5b8e, 5); call(0x1007_623c, -0x3_f957);           /* call 0x1007623c */
            ii(0x100b_5b93, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100b_5b96, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_5b99, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_5b9b, 2); if(jz(0x100b_5ba2, 0x5)) goto l_0x100b_5ba2; /* jz 0x100b5ba2 */
        l_0x100b_5b9d:
            ii(0x100b_5b9d, 5); jmp(0x100b_5c80, 0xde); goto l_0x100b_5c80; /* jmp 0x100b5c80 */
        l_0x100b_5ba2:
            ii(0x100b_5ba2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5ba5, 5); call(0x1007_63a0, -0x3_f80a);           /* call 0x100763a0 */
            ii(0x100b_5baa, 5); call(0x1007_623c, -0x3_f973);           /* call 0x1007623c */
            ii(0x100b_5baf, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x100b_5bb3, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_5bb6, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100b_5bba, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_5bbc, 6); if(jle(0x100b_5c80, 0xbe)) goto l_0x100b_5c80; /* jle 0x100b5c80 */
            ii(0x100b_5bc2, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x100b_5bc6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5bc9, 5); call(0x1007_63a0, -0x3_f82e);           /* call 0x100763a0 */
            ii(0x100b_5bce, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_5bd1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_5bd4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5bd7, 5); call(0x1007_63a0, -0x3_f83c);           /* call 0x100763a0 */
            ii(0x100b_5bdc, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100b_5bdf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_5be2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_5be5, 5); call(0x1007_6aac, -0x3_f13e);           /* call 0x10076aac */
            ii(0x100b_5bea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5bec, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_5bef, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100b_5bf1, 5); call(0x100a_95c1, -0xc635);             /* call 0x100a95c1 */
            ii(0x100b_5bf6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5bf9, 5); call(0x1007_63a0, -0x3_f85e);           /* call 0x100763a0 */
            ii(0x100b_5bfe, 5); call(0x1007_623c, -0x3_f9c7);           /* call 0x1007623c */
            ii(0x100b_5c03, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_5c05, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5c08, 5); call(0x1007_63a0, -0x3_f86d);           /* call 0x100763a0 */
            ii(0x100b_5c0d, 5); call(0x1007_623c, -0x3_f9d6);           /* call 0x1007623c */
            ii(0x100b_5c12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5c14, 4); mov(ax, memw[ds, ebx + 0xe]);           /* mov ax, [ebx+0xe] */
            ii(0x100b_5c18, 5); imul(ax, memw[ds, edx + 0x14]);         /* imul ax, [edx+0x14] */
            ii(0x100b_5c1d, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
        l_0x100b_5c20:
            ii(0x100b_5c20, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_5c23, 5); call(0x1008_9860, -0x2_c3c8);           /* call 0x10089860 */
            ii(0x100b_5c28, 1); cwde();                                 /* cwde */
            ii(0x100b_5c29, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_5c2c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_5c2f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_5c31, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_5c34, 5); call(0x1008_982c, -0x2_c40d);           /* call 0x1008982c */
            ii(0x100b_5c39, 1); cwde();                                 /* cwde */
            ii(0x100b_5c3a, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100b_5c3c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_5c3e, 3); mov(memd[ss, ebp - 0x34], edx);         /* mov [ebp-0x34], edx */
            ii(0x100b_5c41, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100b_5c44, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100b_5c46, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_5c4b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_5c4d, 2); if(jz(0x100b_5c74, 0x25)) goto l_0x100b_5c74; /* jz 0x100b5c74 */
            ii(0x100b_5c4f, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100b_5c52, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100b_5c54, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_5c59, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100b_5c5d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_5c5f, 3); cmp(eax, 0x7f);                         /* cmp eax, 0x7f */
            ii(0x100b_5c62, 2); if(jle(0x100b_5c6c, 0x8)) goto l_0x100b_5c6c; /* jle 0x100b5c6c */
            ii(0x100b_5c64, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100b_5c67, 3); mov(memb[ds, eax], 0x7f);               /* mov byte [eax], 0x7f */
            ii(0x100b_5c6a, 2); jmp(0x100b_5c74, 0x8); goto l_0x100b_5c74; /* jmp 0x100b5c74 */
        l_0x100b_5c6c:
            ii(0x100b_5c6c, 3); mov(al, memb[ss, ebp - 0x30]);          /* mov al, [ebp-0x30] */
            ii(0x100b_5c6f, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x100b_5c72, 2); add(memb[ds, edx], al);                 /* add [edx], al */
        l_0x100b_5c74:
            ii(0x100b_5c74, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_5c77, 5); call(0x100a_96db, -0xc5a1);             /* call 0x100a96db */
            ii(0x100b_5c7c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_5c7e, 2); if(jnz(0x100b_5c20, -0x60)) goto l_0x100b_5c20; /* jnz 0x100b5c20 */
        l_0x100b_5c80:
            ii(0x100b_5c80, 5); jmp(0x100b_5afb, -0x18a); goto l_0x100b_5afb; /* jmp 0x100b5afb */
        l_0x100b_5c85:
            ii(0x100b_5c85, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5c87, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5c8a, 5); call(0x1007_5f6c, -0x3_fd23);           /* call 0x10075f6c */
            ii(0x100b_5c8f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5c91, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_5c92, 1); pop(edi);                               /* pop edi */
            ii(0x100b_5c93, 1); pop(esi);                               /* pop esi */
            ii(0x100b_5c94, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_5c95, 1); ret();                                  /* ret */
        }
    }
}
