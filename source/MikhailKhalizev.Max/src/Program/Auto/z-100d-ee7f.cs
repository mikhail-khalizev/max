using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_ee7f-ce89082b")]
        public void Method_100d_ee7f()
        {
            ii(0x100d_ee7f, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_ee84, 5); call(Definitions.sys_check_available_stack_size, 0x8_6ec9); /* call 0x10165d52 */
            ii(0x100d_ee89, 1); push(ecx);                              /* push ecx */
            ii(0x100d_ee8a, 1); push(esi);                              /* push esi */
            ii(0x100d_ee8b, 1); push(edi);                              /* push edi */
            ii(0x100d_ee8c, 1); push(ebp);                              /* push ebp */
            ii(0x100d_ee8d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_ee8f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_ee95, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_ee98, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100d_ee9b, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100d_ee9e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_eea1, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100d_eea4, 6); mov(memd[ds, edx + 959], eax);          /* mov [edx+0x3bf], eax */
            ii(0x100d_eeaa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_eead, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100d_eeb0, 6); cmp(eax, memd[ds, edx + 955]);          /* cmp eax, [edx+0x3bb] */
            ii(0x100d_eeb6, 2); if(jnz(0x100d_eefc, 0x44)) goto l_0x100d_eefc; /* jnz 0x100deefc */
            ii(0x100d_eeb8, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100d_eebc, 2); if(jz(0x100d_eed7, 0x19)) goto l_0x100d_eed7; /* jz 0x100deed7 */
            ii(0x100d_eebe, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_eec1, 6); mov(eax, memd[ds, eax + 955]);          /* mov eax, [eax+0x3bb] */
            ii(0x100d_eec7, 5); call(0x100d_0149, -0xed83);             /* call 0x100d0149 */
            ii(0x100d_eecc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_eece, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_eed1, 4); cmp(dx, memw[ds, eax + 89]);            /* cmp dx, [eax+0x59] */
            ii(0x100d_eed5, 2); if(jz(0x100d_eed9, 2)) goto l_0x100d_eed9; /* jz 0x100deed9 */
        l_0x100d_eed7:
            ii(0x100d_eed7, 2); jmp(0x100d_eee3, 0xa); goto l_0x100d_eee3; /* jmp 0x100deee3 */
        l_0x100d_eed9:
            ii(0x100d_eed9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_eedc, 5); call(0x100d_e575, -0x96c);              /* call 0x100de575 */
            ii(0x100d_eee1, 2); jmp(0x100d_eef6, 0x13); goto l_0x100d_eef6; /* jmp 0x100deef6 */
        l_0x100d_eee3:
            ii(0x100d_eee3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_eee6, 5); call(0x100d_5018, -0x9ed3);             /* call 0x100d5018 */
            ii(0x100d_eeeb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_eeee, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_eef1, 5); call(0x100d_e7d6, -0x720);              /* call 0x100de7d6 */
        l_0x100d_eef6:
            ii(0x100d_eef6, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x100d_eefa, 2); jmp(0x100d_ef0f, 0x13); goto l_0x100d_ef0f; /* jmp 0x100def0f */
        l_0x100d_eefc:
            ii(0x100d_eefc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_eefe, 3); mov(bl, memb[ss, ebp - 4]);             /* mov bl, [ebp-0x4] */
            ii(0x100d_ef01, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_ef04, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_ef07, 5); call(0x100d_aaef, -0x441d);             /* call 0x100daaef */
            ii(0x100d_ef0c, 3); mov(memb[ss, ebp - 16], al);            /* mov [ebp-0x10], al */
        l_0x100d_ef0f:
            ii(0x100d_ef0f, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x100d_ef12, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_ef14, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_ef15, 1); pop(edi);                               /* pop edi */
            ii(0x100d_ef16, 1); pop(esi);                               /* pop esi */
            ii(0x100d_ef17, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_ef18, 1); ret();                                  /* ret */
        }
    }
}
