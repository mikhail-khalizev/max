using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4048-62f7e028")]
        public void Method_1007_4048()
        {
            ii(0x1007_4048, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_404d, 5); call(Definitions.sys_check_available_stack_size, 0xf_1d00); /* call 0x10165d52 */
            ii(0x1007_4052, 1); push(ecx);                              /* push ecx */
            ii(0x1007_4053, 1); push(esi);                              /* push esi */
            ii(0x1007_4054, 1); push(edi);                              /* push edi */
            ii(0x1007_4055, 1); push(ebp);                              /* push ebp */
            ii(0x1007_4056, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4058, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_405e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_4061, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_4064, 3); mov(memd[ss, ebp - 0xc], ebx);          /* mov [ebp-0xc], ebx */
            ii(0x1007_4067, 7); test(memd[ss, ebp - 0xc], 0x10);        /* test dword [ebp-0xc], 0x10 */
            ii(0x1007_406e, 2); if(jz(0x1007_40db, 0x6b)) goto l_0x1007_40db; /* jz 0x100740db */
            ii(0x1007_4070, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1007_4074, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_4077, 1); inc(eax);                               /* inc eax */
            ii(0x1007_4078, 1); cwde();                                 /* cwde */
            ii(0x1007_4079, 5); call(0x1007_3cfd, -0x381);              /* call 0x10073cfd */
            ii(0x1007_407e, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_4083, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_4086, 2); if(jnz(0x1007_4094, 0xc)) goto l_0x1007_4094; /* jnz 0x10074094 */
            ii(0x1007_4088, 7); mov(memd[ss, ebp - 0x10], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1007_408f, 5); jmp(0x1007_4108, 0x74); goto l_0x1007_4108; /* jmp 0x10074108 */
        l_0x1007_4094:
            ii(0x1007_4094, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_4097, 1); inc(eax);                               /* inc eax */
            ii(0x1007_4098, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_409b, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_409f, 5); call(0x1007_3cfd, -0x3a7);              /* call 0x10073cfd */
            ii(0x1007_40a4, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_40a9, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_40ac, 2); if(jnz(0x1007_40b7, 9)) goto l_0x1007_40b7; /* jnz 0x100740b7 */
            ii(0x1007_40ae, 7); mov(memd[ss, ebp - 0x10], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1007_40b5, 2); jmp(0x1007_4108, 0x51); goto l_0x1007_4108; /* jmp 0x10074108 */
        l_0x1007_40b7:
            ii(0x1007_40b7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_40ba, 1); inc(eax);                               /* inc eax */
            ii(0x1007_40bb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_40be, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_40c1, 1); inc(eax);                               /* inc eax */
            ii(0x1007_40c2, 1); cwde();                                 /* cwde */
            ii(0x1007_40c3, 5); call(0x1007_3cfd, -0x3cb);              /* call 0x10073cfd */
            ii(0x1007_40c8, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_40cd, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_40d0, 2); if(jnz(0x1007_40db, 9)) goto l_0x1007_40db; /* jnz 0x100740db */
            ii(0x1007_40d2, 7); mov(memd[ss, ebp - 0x10], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1007_40d9, 2); jmp(0x1007_4108, 0x2d); goto l_0x1007_4108; /* jmp 0x10074108 */
        l_0x1007_40db:
            ii(0x1007_40db, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1007_40df, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_40e3, 5); call(0x1007_3cfd, -0x3eb);              /* call 0x10073cfd */
            ii(0x1007_40e8, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_40ed, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_40f0, 2); if(jnz(0x1007_40fb, 9)) goto l_0x1007_40fb; /* jnz 0x100740fb */
            ii(0x1007_40f2, 7); mov(memd[ss, ebp - 0x14], 1);           /* mov dword [ebp-0x14], 0x1 */
            ii(0x1007_40f9, 2); jmp(0x1007_4102, 7); goto l_0x1007_4102; /* jmp 0x10074102 */
        l_0x1007_40fb:
            ii(0x1007_40fb, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x1007_4102:
            ii(0x1007_4102, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_4105, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1007_4108:
            ii(0x1007_4108, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_410b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_410d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_410e, 1); pop(edi);                               /* pop edi */
            ii(0x1007_410f, 1); pop(esi);                               /* pop esi */
            ii(0x1007_4110, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_4111, 1); ret();                                  /* ret */
        }
    }
}
