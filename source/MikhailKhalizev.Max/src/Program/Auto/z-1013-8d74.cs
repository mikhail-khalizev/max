using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_8d74-25a3647b")]
        public void Method_1013_8d74()
        {
            ii(0x1013_8d74, 5); push(0x68);                             /* push 0x68 */
            ii(0x1013_8d79, 5); call(Definitions.sys_check_available_stack_size, 0x2_cfd4); /* call 0x10165d52 */
            ii(0x1013_8d7e, 1); push(ecx);                              /* push ecx */
            ii(0x1013_8d7f, 1); push(esi);                              /* push esi */
            ii(0x1013_8d80, 1); push(edi);                              /* push edi */
            ii(0x1013_8d81, 1); push(ebp);                              /* push ebp */
            ii(0x1013_8d82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_8d84, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1013_8d8a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_8d8d, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_8d90, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_8d93, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_8d9a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_8d9d, 3); dec(memd[ss, ebp - 0x8]);               /* dec dword [ebp-0x8] */
            ii(0x1013_8da0, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_8da4, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_8da7, 2); if(jnz(0x1013_8dbb, 0x12)) goto l_0x1013_8dbb; /* jnz 0x10138dbb */
            ii(0x1013_8da9, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8dad, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_8db0, 6); mov(eax, memd[ds, eax + 0x101b_d36c]);  /* mov eax, [eax+0x101bd36c] */
            ii(0x1013_8db6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_8db9, 2); jmp(0x1013_8e1e, 0x63); goto l_0x1013_8e1e; /* jmp 0x10138e1e */
        l_0x1013_8dbb:
            ii(0x1013_8dbb, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_8dbf, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1013_8dc2, 2); if(jnz(0x1013_8dd6, 0x12)) goto l_0x1013_8dd6; /* jnz 0x10138dd6 */
            ii(0x1013_8dc4, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8dc8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_8dcb, 6); mov(eax, memd[ds, eax + 0x101b_d3a8]);  /* mov eax, [eax+0x101bd3a8] */
            ii(0x1013_8dd1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_8dd4, 2); jmp(0x1013_8e1e, 0x48); goto l_0x1013_8e1e; /* jmp 0x10138e1e */
        l_0x1013_8dd6:
            ii(0x1013_8dd6, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_8dda, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1013_8ddd, 2); if(jnz(0x1013_8df1, 0x12)) goto l_0x1013_8df1; /* jnz 0x10138df1 */
            ii(0x1013_8ddf, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8de3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_8de6, 6); mov(eax, memd[ds, eax + 0x101b_d408]);  /* mov eax, [eax+0x101bd408] */
            ii(0x1013_8dec, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_8def, 2); jmp(0x1013_8e1e, 0x2d); goto l_0x1013_8e1e; /* jmp 0x10138e1e */
        l_0x1013_8df1:
            ii(0x1013_8df1, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_8df5, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_8df8, 2); if(jnz(0x1013_8e1e, 0x24)) goto l_0x1013_8e1e; /* jnz 0x10138e1e */
            ii(0x1013_8dfa, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8dfe, 1); inc(eax);                               /* inc eax */
            ii(0x1013_8dff, 1); push(eax);                              /* push eax */
            ii(0x1013_8e00, 5); mov(eax, StringDefinitions.Scenario);   /* mov eax, 0x101ac86f */
            ii(0x1013_8e05, 1); push(eax);                              /* push eax */
            ii(0x1013_8e06, 5); mov(eax, StringDefinitions.SI2);        /* mov eax, 0x101ac878 */
            ii(0x1013_8e0b, 1); push(eax);                              /* push eax */
            ii(0x1013_8e0c, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1013_8e0f, 1); push(eax);                              /* push eax */
            ii(0x1013_8e10, 5); call(Definitions.sys_sprintf, 0x2_d0ec); /* call 0x10165f01 */
            ii(0x1013_8e15, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1013_8e18, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1013_8e1b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1013_8e1e:
            ii(0x1013_8e1e, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_8e22, 2); if(jz(0x1013_8e32, 0xe)) goto l_0x1013_8e32; /* jz 0x10138e32 */
            ii(0x1013_8e24, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_8e27, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_8e2a, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1013_8e2d, 5); call(Definitions.sys_strcpy, 0x2_d09d); /* call 0x10165ecf */
        l_0x1013_8e32:
            ii(0x1013_8e32, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_8e34, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_8e35, 1); pop(edi);                               /* pop edi */
            ii(0x1013_8e36, 1); pop(esi);                               /* pop esi */
            ii(0x1013_8e37, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_8e38, 1); ret();                                  /* ret */
        }
    }
}
