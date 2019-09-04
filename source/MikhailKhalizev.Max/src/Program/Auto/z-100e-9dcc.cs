using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9dcc-d24a49ee")]
        public void Method_100e_9dcc()
        {
            ii(0x100e_9dcc, 5); push(0x60);                             /* push 0x60 */
            ii(0x100e_9dd1, 5); call(Definitions.sys_check_available_stack_size, 0x7_bf7c); /* call 0x10165d52 */
            ii(0x100e_9dd6, 1); push(esi);                              /* push esi */
            ii(0x100e_9dd7, 1); push(edi);                              /* push edi */
            ii(0x100e_9dd8, 1); push(ebp);                              /* push ebp */
            ii(0x100e_9dd9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_9ddb, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100e_9de1, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100e_9de4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_9de7, 3); mov(memd[ss, ebp - 12], ebx);           /* mov [ebp-0xc], ebx */
            ii(0x100e_9dea, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x100e_9ded, 3); mov(ebx, memd[ss, ebp + 16]);           /* mov ebx, [ebp+0x10] */
            ii(0x100e_9df0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_9df3, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100e_9df6, 5); call(0x100e_9c68, -0x193);              /* call 0x100e9c68 */
            ii(0x100e_9dfb, 2); test(al, al);                           /* test al, al */
            ii(0x100e_9dfd, 6); if(jz(0x100e_9f61, 0x15e)) goto l_0x100e_9f61; /* jz 0x100e9f61 */
            ii(0x100e_9e03, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_9e06, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100e_9e09, 5); call(0x100e_9d58, -0xb6);               /* call 0x100e9d58 */
            ii(0x100e_9e0e, 2); test(al, al);                           /* test al, al */
            ii(0x100e_9e10, 2); if(jz(0x100e_9e6a, 0x58)) goto l_0x100e_9e6a; /* jz 0x100e9e6a */
            ii(0x100e_9e12, 5); call(0x100d_531c, -0x1_4afb);           /* call 0x100d531c */
            ii(0x100e_9e17, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_9e1c, 1); push(eax);                              /* push eax */
            ii(0x100e_9e1d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_9e1f, 3); mov(al, memb[ss, ebp + 24]);            /* mov al, [ebp+0x18] */
            ii(0x100e_9e22, 1); push(eax);                              /* push eax */
            ii(0x100e_9e23, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x100e_9e26, 1); push(eax);                              /* push eax */
            ii(0x100e_9e27, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9e2a, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x100e_9e2e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_9e31, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100e_9e35, 1); cwde();                                 /* cwde */
            ii(0x100e_9e36, 1); push(eax);                              /* push eax */
            ii(0x100e_9e37, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9e3a, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100e_9e3e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_9e41, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100e_9e44, 1); cwde();                                 /* cwde */
            ii(0x100e_9e45, 1); push(eax);                              /* push eax */
            ii(0x100e_9e46, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9e49, 3); mov(eax, memd[ds, eax + 2]);            /* mov eax, [eax+0x2] */
            ii(0x100e_9e4c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_9e4f, 1); push(eax);                              /* push eax */
            ii(0x100e_9e50, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9e53, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x100e_9e56, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x100e_9e59, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100e_9e5d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_9e60, 5); call(0x100e_9ae5, -0x380);              /* call 0x100e9ae5 */
            ii(0x100e_9e65, 5); jmp(0x100e_9f61, 0xf7); goto l_0x100e_9f61; /* jmp 0x100e9f61 */
        l_0x100e_9e6a:
            ii(0x100e_9e6a, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100e_9e6d, 3); sub(eax, memd[ss, ebp - 32]);           /* sub eax, [ebp-0x20] */
            ii(0x100e_9e70, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100e_9e73, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100e_9e76, 3); sub(eax, memd[ss, ebp - 28]);           /* sub eax, [ebp-0x1c] */
            ii(0x100e_9e79, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100e_9e7c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9e7f, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100e_9e83, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_9e86, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100e_9e89, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100e_9e8c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9e8f, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x100e_9e93, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_9e96, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100e_9e9a, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100e_9e9d, 4); movsx(edx, memw[ss, ebp - 48]);         /* movsx edx, word [ebp-0x30] */
            ii(0x100e_9ea1, 4); movsx(eax, memw[ss, ebp - 44]);         /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_9ea5, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100e_9ea8, 5); call(Definitions.sys_malloc, 0x8_1131); /* call 0x1016afde */
            ii(0x100e_9ead, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100e_9eb0, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100e_9eb4, 4); imul(eax, memd[ss, ebp - 28]);          /* imul eax, [ebp-0x1c] */
            ii(0x100e_9eb8, 3); add(eax, memd[ss, ebp - 32]);           /* add eax, [ebp-0x20] */
            ii(0x100e_9ebb, 3); add(memd[ss, ebp - 16], eax);           /* add [ebp-0x10], eax */
            ii(0x100e_9ebe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9ec1, 3); mov(edx, memd[ss, ebp - 28]);           /* mov edx, [ebp-0x1c] */
            ii(0x100e_9ec4, 3); sub(edx, memd[ds, eax + 4]);            /* sub edx, [eax+0x4] */
            ii(0x100e_9ec7, 4); movsx(eax, memw[ss, ebp - 44]);         /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_9ecb, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_9ece, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100e_9ed1, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100e_9ed4, 2); sub(eax, memd[ds, ebx]);                /* sub eax, [ebx] */
            ii(0x100e_9ed6, 3); add(eax, memd[ss, ebp - 52]);           /* add eax, [ebp-0x34] */
            ii(0x100e_9ed9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_9edb, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100e_9ede, 4); movsx(eax, memw[ss, ebp - 44]);         /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_9ee2, 1); push(eax);                              /* push eax */
            ii(0x100e_9ee3, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100e_9ee6, 1); push(eax);                              /* push eax */
            ii(0x100e_9ee7, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100e_9eeb, 1); push(eax);                              /* push eax */
            ii(0x100e_9eec, 4); movsx(eax, memw[ss, ebp - 40]);         /* movsx eax, word [ebp-0x28] */
            ii(0x100e_9ef0, 1); push(eax);                              /* push eax */
            ii(0x100e_9ef1, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x100e_9ef5, 1); push(eax);                              /* push eax */
            ii(0x100e_9ef6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_9ef9, 1); push(eax);                              /* push eax */
            ii(0x100e_9efa, 5); call(/* sys */ 0x1016_abbc, 0x8_0cbd);  /* call 0x1016abbc */
            ii(0x100e_9eff, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100e_9f02, 5); call(0x100d_531c, -0x1_4beb);           /* call 0x100d531c */
            ii(0x100e_9f07, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_9f0c, 1); push(eax);                              /* push eax */
            ii(0x100e_9f0d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_9f0f, 3); mov(al, memb[ss, ebp + 24]);            /* mov al, [ebp+0x18] */
            ii(0x100e_9f12, 1); push(eax);                              /* push eax */
            ii(0x100e_9f13, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x100e_9f16, 1); push(eax);                              /* push eax */
            ii(0x100e_9f17, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x100e_9f1b, 1); push(eax);                              /* push eax */
            ii(0x100e_9f1c, 4); movsx(eax, memw[ss, ebp - 44]);         /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_9f20, 1); push(eax);                              /* push eax */
            ii(0x100e_9f21, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_9f23, 1); push(eax);                              /* push eax */
            ii(0x100e_9f24, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100e_9f26, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x100e_9f29, 4); movsx(edx, memw[ss, ebp - 44]);         /* movsx edx, word [ebp-0x2c] */
            ii(0x100e_9f2d, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x100e_9f30, 5); call(0x100e_9ae5, -0x450);              /* call 0x100e9ae5 */
            ii(0x100e_9f35, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100e_9f39, 1); push(eax);                              /* push eax */
            ii(0x100e_9f3a, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_9f3d, 1); push(eax);                              /* push eax */
            ii(0x100e_9f3e, 4); movsx(eax, memw[ss, ebp - 44]);         /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_9f42, 1); push(eax);                              /* push eax */
            ii(0x100e_9f43, 4); movsx(eax, memw[ss, ebp - 40]);         /* movsx eax, word [ebp-0x28] */
            ii(0x100e_9f47, 1); push(eax);                              /* push eax */
            ii(0x100e_9f48, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x100e_9f4c, 1); push(eax);                              /* push eax */
            ii(0x100e_9f4d, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100e_9f50, 1); push(eax);                              /* push eax */
            ii(0x100e_9f51, 5); call(/* sys */ 0x1016_abbc, 0x8_0c66);  /* call 0x1016abbc */
            ii(0x100e_9f56, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100e_9f59, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x100e_9f5c, 5); call(Definitions.sys_free, 0x8_1160);   /* call 0x1016b0c1 */
        l_0x100e_9f61:
            ii(0x100e_9f61, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9f63, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_9f64, 1); pop(edi);                               /* pop edi */
            ii(0x100e_9f65, 1); pop(esi);                               /* pop esi */
            ii(0x100e_9f66, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
