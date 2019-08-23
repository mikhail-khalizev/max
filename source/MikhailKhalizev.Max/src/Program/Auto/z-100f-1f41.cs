using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_1f41-71161f5b")]
        public void Method_100f_1f41()
        {
            ii(0x100f_1f41, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100f_1f46, 5); calld(Definitions.sys_check_available_stack_size, 0x7_3e07); /* call 0x10165d52 */
            ii(0x100f_1f4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_1f4c, 1); pushd(esi);                             /* push esi */
            ii(0x100f_1f4d, 1); pushd(edi);                             /* push edi */
            ii(0x100f_1f4e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_1f4f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_1f51, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100f_1f57, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_1f5a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100f_1f5d, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100f_1f60, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1f63, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100f_1f67, 2); if(jzd(0x100f_1f72, 0x9)) goto l_0x100f_1f72; /* jz 0x100f1f72 */
            ii(0x100f_1f69, 7); mov(memd_a32[ss, ebp - 0x10], 0x2);     /* mov dword [ebp-0x10], 0x2 */
            ii(0x100f_1f70, 2); jmpd(0x100f_1f79, 0x7); goto l_0x100f_1f79; /* jmp 0x100f1f79 */
        l_0x100f_1f72:
            ii(0x100f_1f72, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
        l_0x100f_1f79:
            ii(0x100f_1f79, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1f7c, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100f_1f7f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_1f82, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_1f86, 1); dec(eax);                               /* dec eax */
            ii(0x100f_1f87, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_1f89, 2); if(jgd(0x100f_1fa1, 0x16)) goto l_0x100f_1fa1; /* jg 0x100f1fa1 */
            ii(0x100f_1f8b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1f8e, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100f_1f91, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_1f94, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_1f97, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_1f99, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_1f9d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_1f9f, 2); if(jged(0x100f_1fa3, 0x2)) goto l_0x100f_1fa3; /* jge 0x100f1fa3 */
        l_0x100f_1fa1:
            ii(0x100f_1fa1, 2); jmpd(0x100f_1fb5, 0x12); goto l_0x100f_1fb5; /* jmp 0x100f1fb5 */
        l_0x100f_1fa3:
            ii(0x100f_1fa3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1fa6, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_1fa9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_1fac, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_1fb0, 1); dec(eax);                               /* dec eax */
            ii(0x100f_1fb1, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_1fb3, 2); if(jled(0x100f_1fb7, 0x2)) goto l_0x100f_1fb7; /* jle 0x100f1fb7 */
        l_0x100f_1fb5:
            ii(0x100f_1fb5, 2); jmpd(0x100f_1fcd, 0x16); goto l_0x100f_1fcd; /* jmp 0x100f1fcd */
        l_0x100f_1fb7:
            ii(0x100f_1fb7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1fba, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_1fbd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_1fc0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_1fc3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_1fc5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_1fc9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_1fcb, 2); if(jged(0x100f_1fcf, 0x2)) goto l_0x100f_1fcf; /* jge 0x100f1fcf */
        l_0x100f_1fcd:
            ii(0x100f_1fcd, 2); jmpd(0x100f_1fd8, 0x9); goto l_0x100f_1fd8; /* jmp 0x100f1fd8 */
        l_0x100f_1fcf:
            ii(0x100f_1fcf, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x100f_1fd6, 2); jmpd(0x100f_1fdf, 0x7); goto l_0x100f_1fdf; /* jmp 0x100f1fdf */
        l_0x100f_1fd8:
            ii(0x100f_1fd8, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x100f_1fdf:
            ii(0x100f_1fdf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_1fe2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_1fe5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_1fe8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_1fea, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_1feb, 1); popd(edi);                              /* pop edi */
            ii(0x100f_1fec, 1); popd(esi);                              /* pop esi */
            ii(0x100f_1fed, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_1fee, 1); retd();                                 /* ret */
        }
    }
}
