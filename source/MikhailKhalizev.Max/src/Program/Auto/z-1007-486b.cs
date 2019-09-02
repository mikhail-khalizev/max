using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_486b-d1bbc9ae")]
        public void Method_1007_486b()
        {
            ii(0x1007_486b, 5); push(0x30);                             /* push 0x30 */
            ii(0x1007_4870, 5); call(Definitions.sys_check_available_stack_size, 0xf_14dd); /* call 0x10165d52 */
            ii(0x1007_4875, 1); push(ecx);                              /* push ecx */
            ii(0x1007_4876, 1); push(esi);                              /* push esi */
            ii(0x1007_4877, 1); push(edi);                              /* push edi */
            ii(0x1007_4878, 1); push(ebp);                              /* push ebp */
            ii(0x1007_4879, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_487b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_4881, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_4884, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_4887, 3); mov(memd[ss, ebp - 12], ebx);           /* mov [ebp-0xc], ebx */
            ii(0x1007_488a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_488d, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1007_4890, 2); jmp(0x1007_48df, 0x4d); goto l_0x1007_48df; /* jmp 0x100748df */
        l_0x1007_4892:
            ii(0x1007_4892, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_4896, 5); jmp(0x1007_494b, 0xb0); goto l_0x1007_494b; /* jmp 0x1007494b */
        l_0x1007_489b:
            ii(0x1007_489b, 7); mov(memd[ss, ebp - 12], 0x100);         /* mov dword [ebp-0xc], 0x100 */
            ii(0x1007_48a2, 5); jmp(0x1007_492d, 0x86); goto l_0x1007_492d; /* jmp 0x1007492d */
        l_0x1007_48a7:
            ii(0x1007_48a7, 5); cmp(memw[ss, ebp - 8], 0x4d);           /* cmp word [ebp-0x8], 0x4d */
            ii(0x1007_48ac, 2); if(jz(0x1007_48b5, 7)) goto l_0x1007_48b5; /* jz 0x100748b5 */
            ii(0x1007_48ae, 5); cmp(memw[ss, ebp - 8], 0x47);           /* cmp word [ebp-0x8], 0x47 */
            ii(0x1007_48b3, 2); if(jnz(0x1007_48b7, 2)) goto l_0x1007_48b7; /* jnz 0x100748b7 */
        l_0x1007_48b5:
            ii(0x1007_48b5, 2); jmp(0x1007_48be, 7); goto l_0x1007_48be; /* jmp 0x100748be */
        l_0x1007_48b7:
            ii(0x1007_48b7, 5); cmp(memw[ss, ebp - 8], 0x45);           /* cmp word [ebp-0x8], 0x45 */
            ii(0x1007_48bc, 2); if(jnz(0x1007_48c0, 2)) goto l_0x1007_48c0; /* jnz 0x100748c0 */
        l_0x1007_48be:
            ii(0x1007_48be, 2); jmp(0x1007_48c7, 7); goto l_0x1007_48c7; /* jmp 0x100748c7 */
        l_0x1007_48c0:
            ii(0x1007_48c0, 5); cmp(memw[ss, ebp - 8], 0x53);           /* cmp word [ebp-0x8], 0x53 */
            ii(0x1007_48c5, 2); if(jnz(0x1007_48c9, 2)) goto l_0x1007_48c9; /* jnz 0x100748c9 */
        l_0x1007_48c7:
            ii(0x1007_48c7, 2); jmp(0x1007_48d0, 7); goto l_0x1007_48d0; /* jmp 0x100748d0 */
        l_0x1007_48c9:
            ii(0x1007_48c9, 5); cmp(memw[ss, ebp - 8], 0x2a);           /* cmp word [ebp-0x8], 0x2a */
            ii(0x1007_48ce, 2); if(jnz(0x1007_48d2, 2)) goto l_0x1007_48d2; /* jnz 0x100748d2 */
        l_0x1007_48d0:
            ii(0x1007_48d0, 2); jmp(0x1007_48db, 9); goto l_0x1007_48db; /* jmp 0x100748db */
        l_0x1007_48d2:
            ii(0x1007_48d2, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_48d6, 5); jmp(0x1007_494b, 0x70); goto l_0x1007_494b; /* jmp 0x1007494b */
        l_0x1007_48db:
            ii(0x1007_48db, 2); jmp(0x1007_492d, 0x50); goto l_0x1007_492d; /* jmp 0x1007492d */
        l_0x1007_48dd:
            ii(0x1007_48dd, 2); jmp(0x1007_492d, 0x4e); goto l_0x1007_492d; /* jmp 0x1007492d */
        l_0x1007_48df:
            ii(0x1007_48df, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1007_48e2, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_48e5, 5); cmp(memw[ss, ebp - 28], 0x27);          /* cmp word [ebp-0x1c], 0x27 */
            ii(0x1007_48ea, 2); if(jb(0x1007_490c, 0x20)) goto l_0x1007_490c; /* jb 0x1007490c */
            ii(0x1007_48ec, 5); cmp(memw[ss, ebp - 28], 0x27);          /* cmp word [ebp-0x1c], 0x27 */
            ii(0x1007_48f1, 2); if(jbe(0x1007_489b, -0x58)) goto l_0x1007_489b; /* jbe 0x1007489b */
            ii(0x1007_48f3, 5); cmp(memw[ss, ebp - 28], 0x2a);          /* cmp word [ebp-0x1c], 0x2a */
            ii(0x1007_48f8, 2); if(jb(0x1007_490a, 0x10)) goto l_0x1007_490a; /* jb 0x1007490a */
            ii(0x1007_48fa, 5); cmp(memw[ss, ebp - 28], 0x2a);          /* cmp word [ebp-0x1c], 0x2a */
            ii(0x1007_48ff, 2); if(jbe(0x1007_489b, -0x66)) goto l_0x1007_489b; /* jbe 0x1007489b */
            ii(0x1007_4901, 5); cmp(memw[ss, ebp - 28], 0x47);          /* cmp word [ebp-0x1c], 0x47 */
            ii(0x1007_4906, 2); if(jz(0x1007_48a7, -0x61)) goto l_0x1007_48a7; /* jz 0x100748a7 */
            ii(0x1007_4908, 2); jmp(0x1007_48dd, -0x2d); goto l_0x1007_48dd; /* jmp 0x100748dd */
        l_0x1007_490a:
            ii(0x1007_490a, 2); jmp(0x1007_48dd, -0x2f); goto l_0x1007_48dd; /* jmp 0x100748dd */
        l_0x1007_490c:
            ii(0x1007_490c, 5); cmp(memw[ss, ebp - 28], 0xf);           /* cmp word [ebp-0x1c], 0xf */
            ii(0x1007_4911, 2); if(jb(0x1007_492b, 0x18)) goto l_0x1007_492b; /* jb 0x1007492b */
            ii(0x1007_4913, 5); cmp(memw[ss, ebp - 28], 0x10);          /* cmp word [ebp-0x1c], 0x10 */
            ii(0x1007_4918, 6); if(jbe(0x1007_4892, -0x8c)) goto l_0x1007_4892; /* jbe 0x10074892 */
            ii(0x1007_491e, 5); cmp(memw[ss, ebp - 28], 0x21);          /* cmp word [ebp-0x1c], 0x21 */
            ii(0x1007_4923, 6); if(jz(0x1007_489b, -0x8e)) goto l_0x1007_489b; /* jz 0x1007489b */
            ii(0x1007_4929, 2); jmp(0x1007_48dd, -0x4e); goto l_0x1007_48dd; /* jmp 0x100748dd */
        l_0x1007_492b:
            ii(0x1007_492b, 2); jmp(0x1007_48dd, -0x50); goto l_0x1007_48dd; /* jmp 0x100748dd */
        l_0x1007_492d:
            ii(0x1007_492d, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_4931, 5); call(0x1007_4705, -0x231);              /* call 0x10074705 */
            ii(0x1007_4936, 3); test(memd[ss, ebp - 12], eax);          /* test [ebp-0xc], eax */
            ii(0x1007_4939, 2); if(jz(0x1007_4941, 6)) goto l_0x1007_4941; /* jz 0x10074941 */
            ii(0x1007_493b, 4); mov(memb[ss, ebp - 24], 1);             /* mov byte [ebp-0x18], 0x1 */
            ii(0x1007_493f, 2); jmp(0x1007_4945, 4); goto l_0x1007_4945; /* jmp 0x10074945 */
        l_0x1007_4941:
            ii(0x1007_4941, 4); mov(memb[ss, ebp - 24], 0);             /* mov byte [ebp-0x18], 0x0 */
        l_0x1007_4945:
            ii(0x1007_4945, 3); mov(al, memb[ss, ebp - 24]);            /* mov al, [ebp-0x18] */
            ii(0x1007_4948, 3); mov(memb[ss, ebp - 16], al);            /* mov [ebp-0x10], al */
        l_0x1007_494b:
            ii(0x1007_494b, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x1007_494e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4950, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_4951, 1); pop(edi);                               /* pop edi */
            ii(0x1007_4952, 1); pop(esi);                               /* pop esi */
            ii(0x1007_4953, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_4954, 1); ret();                                  /* ret */
        }
    }
}
