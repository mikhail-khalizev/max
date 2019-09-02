using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_4165-e5529572")]
        public void Method_1009_4165()
        {
            ii(0x1009_4165, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_416a, 5); call(Definitions.sys_check_available_stack_size, 0xd_1be3); /* call 0x10165d52 */
            ii(0x1009_416f, 1); push(esi);                              /* push esi */
            ii(0x1009_4170, 1); push(edi);                              /* push edi */
            ii(0x1009_4171, 1); push(ebp);                              /* push ebp */
            ii(0x1009_4172, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_4174, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_417a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_417d, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1009_4180, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1009_4183, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1009_4186, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1009_418a, 5); call(0x100c_dec2, 0x3_9d33);            /* call 0x100cdec2 */
            ii(0x1009_418f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4191, 2); if(jnz(0x1009_4199, 6)) goto l_0x1009_4199; /* jnz 0x10094199 */
            ii(0x1009_4193, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_4197, 2); jmp(0x1009_41e9, 0x50); goto l_0x1009_41e9; /* jmp 0x100941e9 */
        l_0x1009_4199:
            ii(0x1009_4199, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1009_419d, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1009_41a1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_41a4, 5); call(0x1009_3e27, -0x382);              /* call 0x10093e27 */
            ii(0x1009_41a9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_41ab, 3); sub(memd[ss, ebp - 0xc], eax);          /* sub [ebp-0xc], eax */
            ii(0x1009_41ae, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1009_41b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_41b4, 2); if(jg(0x1009_41bc, 6)) goto l_0x1009_41bc; /* jg 0x100941bc */
            ii(0x1009_41b6, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_41ba, 2); jmp(0x1009_41e9, 0x2d); goto l_0x1009_41e9; /* jmp 0x100941e9 */
        l_0x1009_41bc:
            ii(0x1009_41bc, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1009_41bf, 5); cmp(memw[ss, ebp - 0xc], -1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1009_41c4, 2); if(jz(0x1009_41e5, 0x1f)) goto l_0x1009_41e5; /* jz 0x100941e5 */
            ii(0x1009_41c6, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_41ca, 3); mov(ebx, memd[ss, ebp - 0x10]);         /* mov ebx, [ebp-0x10] */
            ii(0x1009_41cd, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1009_41d1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_41d4, 5); call(0x1009_6e02, 0x2c29);              /* call 0x10096e02 */
            ii(0x1009_41d9, 2); test(al, al);                           /* test al, al */
            ii(0x1009_41db, 2); if(jz(0x1009_41e3, 6)) goto l_0x1009_41e3; /* jz 0x100941e3 */
            ii(0x1009_41dd, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_41e1, 2); jmp(0x1009_41e9, 6); goto l_0x1009_41e9; /* jmp 0x100941e9 */
        l_0x1009_41e3:
            ii(0x1009_41e3, 2); jmp(0x1009_41bc, -0x29); goto l_0x1009_41bc; /* jmp 0x100941bc */
        l_0x1009_41e5:
            ii(0x1009_41e5, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1009_41e9:
            ii(0x1009_41e9, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1009_41ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_41ee, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_41ef, 1); pop(edi);                               /* pop edi */
            ii(0x1009_41f0, 1); pop(esi);                               /* pop esi */
            ii(0x1009_41f1, 1); ret();                                  /* ret */
        }
    }
}
