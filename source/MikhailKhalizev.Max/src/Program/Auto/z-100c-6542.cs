using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_6542-d2d06128")]
        public void Method_100c_6542()
        {
            ii(0x100c_6542, 5); push(0x34);                             /* push 0x34 */
            ii(0x100c_6547, 5); call(Definitions.sys_check_available_stack_size, 0x9_f806); /* call 0x10165d52 */
            ii(0x100c_654c, 1); push(esi);                              /* push esi */
            ii(0x100c_654d, 1); push(edi);                              /* push edi */
            ii(0x100c_654e, 1); push(ebp);                              /* push ebp */
            ii(0x100c_654f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_6551, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100c_6557, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_655a, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100c_655d, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100c_6560, 3); mov(memd[ss, ebp - 0x8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100c_6563, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100c_656a, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100c_656e, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100c_6572, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_6578, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x100c_657e, 5); call(0x100c_b6b0, 0x512d);              /* call 0x100cb6b0 */
            ii(0x100c_6583, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x100c_6587, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_658a, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_658e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_6594, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100c_6599, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_659b, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100c_659e, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_65a5, 2); jmp(0x100c_65ad, 0x6); goto l_0x100c_65ad; /* jmp 0x100c65ad */
        l_0x100c_65a7:
            ii(0x100c_65a7, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_65aa, 3); inc(memd[ss, ebp - 0x20]);              /* inc dword [ebp-0x20] */
        l_0x100c_65ad:
            ii(0x100c_65ad, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100c_65b1, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100c_65b4, 6); if(jge(0x100c_6639, 0x7f)) goto l_0x100c_6639; /* jge 0x100c6639 */
            ii(0x100c_65ba, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x100c_65be, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_65c1, 5); call(0x100d_fd2c, 0x1_9766);            /* call 0x100dfd2c */
            ii(0x100c_65c6, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_65c9, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_65cc, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100c_65cf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_65d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_65d4, 2); if(jle(0x100c_65eb, 0x15)) goto l_0x100c_65eb; /* jle 0x100c65eb */
            ii(0x100c_65d6, 4); cmp(memb[ss, ebp + 0x10], 0);           /* cmp byte [ebp+0x10], 0x0 */
            ii(0x100c_65da, 2); if(jnz(0x100c_65e9, 0xd)) goto l_0x100c_65e9; /* jnz 0x100c65e9 */
            ii(0x100c_65dc, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_65df, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x100c_65e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_65e5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_65e7, 2); if(jle(0x100c_65eb, 0x2)) goto l_0x100c_65eb; /* jle 0x100c65eb */
        l_0x100c_65e9:
            ii(0x100c_65e9, 2); jmp(0x100c_65ed, 0x2); goto l_0x100c_65ed; /* jmp 0x100c65ed */
        l_0x100c_65eb:
            ii(0x100c_65eb, 2); jmp(0x100c_65fe, 0x11); goto l_0x100c_65fe; /* jmp 0x100c65fe */
        l_0x100c_65ed:
            ii(0x100c_65ed, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100c_65f1, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100c_65f5, 5); call(0x1007_49d4, -0x5_1c26);           /* call 0x100749d4 */
            ii(0x100c_65fa, 2); test(al, al);                           /* test al, al */
            ii(0x100c_65fc, 2); if(jnz(0x100c_6600, 0x2)) goto l_0x100c_6600; /* jnz 0x100c6600 */
        l_0x100c_65fe:
            ii(0x100c_65fe, 2); jmp(0x100c_6634, 0x34); goto l_0x100c_6634; /* jmp 0x100c6634 */
        l_0x100c_6600:
            ii(0x100c_6600, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_6603, 3); mov(eax, memd[ds, eax + 0x10]);         /* mov eax, [eax+0x10] */
            ii(0x100c_6606, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_6609, 3); lea(edx, memd[ds, eax + 0x1]);          /* lea edx, [eax+0x1] */
            ii(0x100c_660c, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_6610, 5); call(0x1007_6e7c, -0x4_f799);           /* call 0x10076e7c */
            ii(0x100c_6615, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_6618, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x100c_661c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_661f, 6); mov(eax, memd[ds, eax + 0xfa]);         /* mov eax, [eax+0xfa] */
            ii(0x100c_6625, 5); call(0x100c_b6b0, 0x5086);              /* call 0x100cb6b0 */
            ii(0x100c_662a, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x100c_662e, 4); cmp(ax, memw[ss, ebp - 0x18]);          /* cmp ax, [ebp-0x18] */
            ii(0x100c_6632, 2); if(jg(0x100c_666f, 0x3b)) goto l_0x100c_666f; /* jg 0x100c666f */
        l_0x100c_6634:
            ii(0x100c_6634, 5); jmp(0x100c_65a7, -0x92); goto l_0x100c_65a7; /* jmp 0x100c65a7 */
        l_0x100c_6639:
            ii(0x100c_6639, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100c_663d, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100c_6641, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_6647, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100c_664c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_664e, 5); call(0x100d_fd2c, 0x1_96d9);            /* call 0x100dfd2c */
            ii(0x100c_6653, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6655, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_6658, 4); cmp(ax, memw[ds, edx + 0x17]);          /* cmp ax, [edx+0x17] */
            ii(0x100c_665c, 2); if(jle(0x100c_666f, 0x11)) goto l_0x100c_666f; /* jle 0x100c666f */
            ii(0x100c_665e, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6663, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100c_6667, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_666a, 5); call(0x100c_64f5, -0x17a);              /* call 0x100c64f5 */
        l_0x100c_666f:
            ii(0x100c_666f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_6671, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_6672, 1); pop(edi);                               /* pop edi */
            ii(0x100c_6673, 1); pop(esi);                               /* pop esi */
            ii(0x100c_6674, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
