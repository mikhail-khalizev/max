using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_cd9c-9231242c")]
        public void Method_100f_cd9c()
        {
            ii(0x100f_cd9c, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100f_cda1, 5); call(Definitions.sys_check_available_stack_size, 0x6_8fac); /* call 0x10165d52 */
            ii(0x100f_cda6, 1); push(ebx);                              /* push ebx */
            ii(0x100f_cda7, 1); push(ecx);                              /* push ecx */
            ii(0x100f_cda8, 1); push(esi);                              /* push esi */
            ii(0x100f_cda9, 1); push(edi);                              /* push edi */
            ii(0x100f_cdaa, 1); push(ebp);                              /* push ebp */
            ii(0x100f_cdab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_cdad, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_cdb3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_cdb6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_cdb9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_cdbc, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100f_cdbf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_cdc2, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_cdc5, 5); call(0x100f_7ed6, -0x4ef4);             /* call 0x100f7ed6 */
            ii(0x100f_cdca, 2); test(al, al);                           /* test al, al */
            ii(0x100f_cdcc, 6); if(jnz(0x100f_ce5d, 0x8b)) goto l_0x100f_ce5d; /* jnz 0x100fce5d */
            ii(0x100f_cdd2, 7); mov(memd[ss, ebp - 0x14], 0x2);         /* mov dword [ebp-0x14], 0x2 */
        l_0x100f_cdd9:
            ii(0x100f_cdd9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_cddc, 3); dec(memw[ds, eax]);                     /* dec word [eax] */
            ii(0x100f_cddf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_cde2, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
            ii(0x100f_cde5, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_cdec, 2); jmp(0x100f_cdf2, 0x4); goto l_0x100f_cdf2; /* jmp 0x100fcdf2 */
        l_0x100f_cdee:
            ii(0x100f_cdee, 4); add(memd[ss, ebp - 0x10], 0x2);         /* add dword [ebp-0x10], 0x2 */
        l_0x100f_cdf2:
            ii(0x100f_cdf2, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_cdf6, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100f_cdf9, 2); if(jge(0x100f_ce54, 0x59)) goto l_0x100f_ce54; /* jge 0x100fce54 */
            ii(0x100f_cdfb, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_ce02, 2); jmp(0x100f_ce0a, 0x6); goto l_0x100f_ce0a; /* jmp 0x100fce0a */
        l_0x100f_ce04:
            ii(0x100f_ce04, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_ce07, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x100f_ce0a:
            ii(0x100f_ce0a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_ce0d, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x100f_ce11, 2); if(jge(0x100f_ce52, 0x3f)) goto l_0x100f_ce52; /* jge 0x100fce52 */
            ii(0x100f_ce13, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_ce17, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_ce1a, 7); mov(dx, memw[ds, eax + 0x101c_5348]);   /* mov dx, [eax+0x101c5348] */
            ii(0x100f_ce21, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_ce24, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100f_ce27, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_ce2b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_ce2e, 7); mov(dx, memw[ds, eax + 0x101c_534a]);   /* mov dx, [eax+0x101c534a] */
            ii(0x100f_ce35, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_ce38, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100f_ce3b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_ce3e, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100f_ce41, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_ce44, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_ce47, 5); call(0x100f_7ed6, -0x4f76);             /* call 0x100f7ed6 */
            ii(0x100f_ce4c, 2); test(al, al);                           /* test al, al */
            ii(0x100f_ce4e, 2); if(jnz(0x100f_ce5d, 0xd)) goto l_0x100f_ce5d; /* jnz 0x100fce5d */
            ii(0x100f_ce50, 2); jmp(0x100f_ce04, -0x4e); goto l_0x100f_ce04; /* jmp 0x100fce04 */
        l_0x100f_ce52:
            ii(0x100f_ce52, 2); jmp(0x100f_cdee, -0x66); goto l_0x100f_cdee; /* jmp 0x100fcdee */
        l_0x100f_ce54:
            ii(0x100f_ce54, 4); add(memd[ss, ebp - 0x14], 0x2);         /* add dword [ebp-0x14], 0x2 */
            ii(0x100f_ce58, 5); jmp(0x100f_cdd9, -0x84); goto l_0x100f_cdd9; /* jmp 0x100fcdd9 */
        l_0x100f_ce5d:
            ii(0x100f_ce5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_ce5f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_ce60, 1); pop(edi);                               /* pop edi */
            ii(0x100f_ce61, 1); pop(esi);                               /* pop esi */
            ii(0x100f_ce62, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_ce63, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_ce64, 1); ret();                                  /* ret */
        }
    }
}
