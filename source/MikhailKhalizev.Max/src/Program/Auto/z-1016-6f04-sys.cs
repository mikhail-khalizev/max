using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6f04-b1c1c07b")]
        public void /* sys */ Method_1016_6f04()
        {
            ii(0x1016_6f04, 1); push(esi);                              /* push esi */
            ii(0x1016_6f05, 1); push(edi);                              /* push edi */
            ii(0x1016_6f06, 1); push(ebp);                              /* push ebp */
            ii(0x1016_6f07, 3); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1016_6f0a, 4); mov(memd[ss, esp + 20], eax);           /* mov [esp+0x14], eax */
            ii(0x1016_6f0e, 4); mov(memd[ss, esp + 4], edx);            /* mov [esp+0x4], edx */
            ii(0x1016_6f12, 4); mov(memd[ss, esp + 16], ebx);           /* mov [esp+0x10], ebx */
            ii(0x1016_6f16, 4); mov(memd[ss, esp + 28], ecx);           /* mov [esp+0x1c], ecx */
            ii(0x1016_6f1a, 5); call(/* sys */ 0x1016_7dac, 0xe8d);     /* call 0x10167dac */
            ii(0x1016_6f1f, 7); cmp(memd[ds, 0x101b_ddbc], 0);          /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_6f26, 6); if(jz(0x1016_7043, 0x117)) goto l_0x1016_7043; /* jz 0x10167043 */
            ii(0x1016_6f2c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6f2e, 6); if(jz(0x1016_7043, 0x10f)) goto l_0x1016_7043; /* jz 0x10167043 */
            ii(0x1016_6f34, 4); mov(esi, memd[ss, esp + 60]);           /* mov esi, [esp+0x3c] */
            ii(0x1016_6f38, 3); mov(edi, memd[ds, eax + 24]);           /* mov edi, [eax+0x18] */
            ii(0x1016_6f3b, 3); imul(esi, edi);                         /* imul esi, edi */
            ii(0x1016_6f3e, 4); mov(ebx, memd[ss, esp + 56]);           /* mov ebx, [esp+0x38] */
            ii(0x1016_6f42, 4); mov(ebp, memd[ss, esp + 16]);           /* mov ebp, [esp+0x10] */
            ii(0x1016_6f46, 3); mov(eax, memd[ds, eax + 44]);           /* mov eax, [eax+0x2c] */
            ii(0x1016_6f49, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_6f4b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_6f4d, 4); mov(memd[ss, esp + 36], ecx);           /* mov [esp+0x24], ecx */
            ii(0x1016_6f51, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_6f53, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1016_6f59, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_6f5b, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1016_6f5f, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_6f61, 6); if(jle(0x1016_7043, 0xdc)) goto l_0x1016_7043; /* jle 0x10167043 */
            ii(0x1016_6f67, 3); imul(eax, edi);                         /* imul eax, edi */
            ii(0x1016_6f6a, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
            ii(0x1016_6f6e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_6f70, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_6f73, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_6f75, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1016_6f77, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1016_6f79, 4); mov(eax, memd[ss, esp + 28]);           /* mov eax, [esp+0x1c] */
            ii(0x1016_6f7d, 1); dec(eax);                               /* dec eax */
            ii(0x1016_6f7e, 4); mov(memd[ss, esp + 24], eax);           /* mov [esp+0x18], eax */
            ii(0x1016_6f82, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_6f84, 1); inc(eax);                               /* inc eax */
            ii(0x1016_6f85, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_6f88, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_6f8c, 4); mov(memd[ss, esp + 32], eax);           /* mov [esp+0x20], eax */
        l_0x1016_6f90:
            ii(0x1016_6f90, 4); mov(eax, memd[ss, esp + 32]);           /* mov eax, [esp+0x20] */
            ii(0x1016_6f94, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1016_6f96, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1016_6f99, 2); if(jz(0x1016_6fba, 0x1f)) goto l_0x1016_6fba; /* jz 0x10166fba */
            ii(0x1016_6f9b, 4); mov(ebx, memd[ss, esp + 64]);           /* mov ebx, [esp+0x40] */
            ii(0x1016_6f9f, 4); mov(ecx, memd[ss, esp + 60]);           /* mov ecx, [esp+0x3c] */
            ii(0x1016_6fa3, 1); push(ebx);                              /* push ebx */
            ii(0x1016_6fa4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_6fa6, 4); mov(eax, memd[ss, esp + 24]);           /* mov eax, [esp+0x18] */
            ii(0x1016_6faa, 1); push(ecx);                              /* push ecx */
            ii(0x1016_6fab, 4); mov(ebx, memd[ss, esp + 36]);           /* mov ebx, [esp+0x24] */
            ii(0x1016_6faf, 4); mov(ecx, memd[ss, esp + 64]);           /* mov ecx, [esp+0x40] */
            ii(0x1016_6fb3, 5); call(/* sys */ 0x1016_6d74, -0x244);    /* call 0x10166d74 */
            ii(0x1016_6fb8, 2); jmp(0x1016_700d, 0x53); goto l_0x1016_700d; /* jmp 0x1016700d */
        l_0x1016_6fba:
            ii(0x1016_6fba, 5); cmp(memd[ss, esp + 28], 0);             /* cmp dword [esp+0x1c], 0x0 */
            ii(0x1016_6fbf, 2); if(jz(0x1016_700d, 0x4c)) goto l_0x1016_700d; /* jz 0x1016700d */
            ii(0x1016_6fc1, 5); mov(eax, memd[ds, 0x101b_ddc8]);        /* mov eax, [0x101bddc8] */
            ii(0x1016_6fc6, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_6fcc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6fd1, 1); push(eax);                              /* push eax */
            ii(0x1016_6fd2, 4); mov(ecx, memd[ss, esp + 28]);           /* mov ecx, [esp+0x1c] */
            ii(0x1016_6fd6, 1); push(ebp);                              /* push ebp */
            ii(0x1016_6fd7, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_6fd9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_6fdb, 1); push(ecx);                              /* push ecx */
            ii(0x1016_6fdc, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_6fde, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1016_6fe0, 5); call(/* sys */ 0x1016_a5a0, 0x35bb);    /* call 0x1016a5a0 */
            ii(0x1016_6fe5, 5); mov(eax, memd[ds, 0x101b_ddc4]);        /* mov eax, [0x101bddc4] */
            ii(0x1016_6fea, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_6ff0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6ff5, 1); push(eax);                              /* push eax */
            ii(0x1016_6ff6, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_6ffa, 4); mov(edx, memd[ss, esp + 28]);           /* mov edx, [esp+0x1c] */
            ii(0x1016_6ffe, 1); push(eax);                              /* push eax */
            ii(0x1016_6fff, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_7001, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_7003, 1); push(edx);                              /* push edx */
            ii(0x1016_7004, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_7006, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_7008, 5); call(/* sys */ 0x1016_a5a0, 0x3593);    /* call 0x1016a5a0 */
        l_0x1016_700d:
            ii(0x1016_700d, 4); mov(eax, memd[ss, esp + 32]);           /* mov eax, [esp+0x20] */
            ii(0x1016_7011, 4); mov(edx, memd[ss, esp + 36]);           /* mov edx, [esp+0x24] */
            ii(0x1016_7015, 4); mov(ebx, memd[ss, esp + 12]);           /* mov ebx, [esp+0xc] */
            ii(0x1016_7019, 4); mov(ecx, memd[ss, esp + 60]);           /* mov ecx, [esp+0x3c] */
            ii(0x1016_701d, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1016_7020, 1); inc(edx);                               /* inc edx */
            ii(0x1016_7021, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1016_7023, 4); mov(memd[ss, esp + 32], eax);           /* mov [esp+0x20], eax */
            ii(0x1016_7027, 4); mov(eax, memd[ss, esp + 8]);            /* mov eax, [esp+0x8] */
            ii(0x1016_702b, 4); mov(memd[ss, esp + 36], edx);           /* mov [esp+0x24], edx */
            ii(0x1016_702f, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_7031, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_7033, 4); mov(edx, memd[ss, esp + 16]);           /* mov edx, [esp+0x10] */
            ii(0x1016_7037, 4); mov(memd[ss, esp + 60], ecx);           /* mov [esp+0x3c], ecx */
            ii(0x1016_703b, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_703d, 6); if(jl(0x1016_6f90, -0xb3)) goto l_0x1016_6f90; /* jl 0x10166f90 */
        l_0x1016_7043:
            ii(0x1016_7043, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1016_7046, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_7047, 1); pop(edi);                               /* pop edi */
            ii(0x1016_7048, 1); pop(esi);                               /* pop esi */
            ii(0x1016_7049, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
