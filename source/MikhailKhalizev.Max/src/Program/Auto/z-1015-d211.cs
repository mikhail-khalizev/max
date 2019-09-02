using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_d211-95b13cb")]
        public void Method_1015_d211()
        {
            ii(0x1015_d211, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1015_d216, 5); call(Definitions.sys_check_available_stack_size, 0x8b37); /* call 0x10165d52 */
            ii(0x1015_d21b, 1); push(ecx);                              /* push ecx */
            ii(0x1015_d21c, 1); push(esi);                              /* push esi */
            ii(0x1015_d21d, 1); push(edi);                              /* push edi */
            ii(0x1015_d21e, 1); push(ebp);                              /* push ebp */
            ii(0x1015_d21f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_d221, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_d227, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_d22a, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1015_d22d, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1015_d230, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_d233, 5); call(0x1007_623c, -0xe_6ffc);           /* call 0x1007623c */
            ii(0x1015_d238, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1015_d23c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_d23f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_d242, 5); call(0x1007_623c, -0xe_700b);           /* call 0x1007623c */
            ii(0x1015_d247, 4); mov(ax, memw[ds, eax + 0xe]);           /* mov ax, [eax+0xe] */
            ii(0x1015_d24b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_d24e, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_d252, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1015_d255, 2); if(jle(0x1015_d279, 0x22)) goto l_0x1015_d279; /* jle 0x1015d279 */
            ii(0x1015_d257, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_d25b, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1015_d260, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1015_d262, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1015_d266, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_d269, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_d26b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_d26e, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1015_d271, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1015_d273, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_d276, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x1015_d279:
            ii(0x1015_d279, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_d27c, 5); cmp(memw[ds, eax + 8], 0x47);           /* cmp word [eax+0x8], 0x47 */
            ii(0x1015_d281, 2); if(jnz(0x1015_d299, 0x16)) goto l_0x1015_d299; /* jnz 0x1015d299 */
            ii(0x1015_d283, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_d286, 5); cmp(memw[ds, eax + 8], 0x4d);           /* cmp word [eax+0x8], 0x4d */
            ii(0x1015_d28b, 2); if(jz(0x1015_d297, 0xa)) goto l_0x1015_d297; /* jz 0x1015d297 */
            ii(0x1015_d28d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_d290, 5); cmp(memw[ds, eax + 8], 0x53);           /* cmp word [eax+0x8], 0x53 */
            ii(0x1015_d295, 2); if(jnz(0x1015_d299, 2)) goto l_0x1015_d299; /* jnz 0x1015d299 */
        l_0x1015_d297:
            ii(0x1015_d297, 2); jmp(0x1015_d29b, 2); goto l_0x1015_d29b; /* jmp 0x1015d29b */
        l_0x1015_d299:
            ii(0x1015_d299, 2); jmp(0x1015_d2a9, 0xe); goto l_0x1015_d2a9; /* jmp 0x1015d2a9 */
        l_0x1015_d29b:
            ii(0x1015_d29b, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_d29e, 2); cwd();                                  /* cwd */
            ii(0x1015_d2a0, 3); sub(ax, dx);                            /* sub ax, dx */
            ii(0x1015_d2a3, 3); sar(ax, 1);                             /* sar ax, 1 */
            ii(0x1015_d2a6, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x1015_d2a9:
            ii(0x1015_d2a9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_d2ac, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1015_d2b0, 2); if(jl(0x1015_d2bb, 9)) goto l_0x1015_d2bb; /* jl 0x1015d2bb */
            ii(0x1015_d2b2, 7); mov(memd[ss, ebp - 0x18], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x1015_d2b9, 2); jmp(0x1015_d2c4, 9); goto l_0x1015_d2c4; /* jmp 0x1015d2c4 */
        l_0x1015_d2bb:
            ii(0x1015_d2bb, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_d2be, 3); sub(eax, memd[ss, ebp - 0x10]);         /* sub eax, [ebp-0x10] */
            ii(0x1015_d2c1, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1015_d2c4:
            ii(0x1015_d2c4, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_d2c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_d2c9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_d2ca, 1); pop(edi);                               /* pop edi */
            ii(0x1015_d2cb, 1); pop(esi);                               /* pop esi */
            ii(0x1015_d2cc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_d2cd, 1); ret();                                  /* ret */
        }
    }
}
