using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6144-dd6b8006")]
        public void Method_100d_6144()
        {
            ii(0x100d_6144, 5); pushd(0x90);                            /* push 0x90 */
            ii(0x100d_6149, 5); calld(Definitions.sys_check_available_stack_size, 0x8_fc04); /* call 0x10165d52 */
            ii(0x100d_614e, 1); pushd(esi);                             /* push esi */
            ii(0x100d_614f, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6150, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6151, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6153, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x100d_6159, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_615c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_615f, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x100d_6162, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100d_6165, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100d_616c, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100d_6173, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6177, 4); movsx(edx, memw_a32[ss, ebp + 0x18]);   /* movsx edx, word [ebp+0x18] */
            ii(0x100d_617b, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_617e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_6181, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100d_6188, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100d_618b, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100d_618d, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6191, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_6194, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x100d_6197, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_619b, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x100d_619e, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x100d_61a1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_61a4, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100d_61a7, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_61aa, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100d_61ad, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100d_61af, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x100d_61b2, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100d_61b4, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_61b7, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61bb, 6); imul(eax, eax, 0xb505);                 /* imul eax, eax, 0xb505 */
            ii(0x100d_61c1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_61c4, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100d_61c7, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100d_61cb, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61cf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_61d1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_61d3, 2); if(jld(0x100d_61e7, 0x12)) goto l_0x100d_61e7; /* jl 0x100d61e7 */
            ii(0x100d_61d5, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100d_61d9, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61dd, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_61df, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_61e3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_61e5, 2); if(jld(0x100d_61e9, 0x2)) goto l_0x100d_61e9; /* jl 0x100d61e9 */
        l_0x100d_61e7:
            ii(0x100d_61e7, 2); jmpd(0x100d_61f7, 0xe); goto l_0x100d_61f7; /* jmp 0x100d61f7 */
        l_0x100d_61e9:
            ii(0x100d_61e9, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x100d_61ed, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61f1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_61f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_61f5, 2); if(jged(0x100d_61f9, 0x2)) goto l_0x100d_61f9; /* jge 0x100d61f9 */
        l_0x100d_61f7:
            ii(0x100d_61f7, 2); jmpd(0x100d_620b, 0x12); goto l_0x100d_620b; /* jmp 0x100d620b */
        l_0x100d_61f9:
            ii(0x100d_61f9, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x100d_61fd, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6201, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_6203, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_6207, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_6209, 2); if(jld(0x100d_620d, 0x2)) goto l_0x100d_620d; /* jl 0x100d620d */
        l_0x100d_620b:
            ii(0x100d_620b, 2); jmpd(0x100d_6215, 0x8); goto l_0x100d_6215; /* jmp 0x100d6215 */
        l_0x100d_620d:
            ii(0x100d_620d, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6211, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6213, 2); if(jgd(0x100d_621a, 0x5)) goto l_0x100d_621a; /* jg 0x100d621a */
        l_0x100d_6215:
            ii(0x100d_6215, 5); if(jmpd_func(0x100d_66ac, 0x492)) return; /* jmp 0x100d66ac */
        l_0x100d_621a:
            ii(0x100d_621a, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100d_621e, 3); sub(eax, memd_a32[ss, ebp - 0x2c]);     /* sub eax, [ebp-0x2c] */
            ii(0x100d_6221, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6223, 2); if(jged(0x100d_6236, 0x11)) goto l_0x100d_6236; /* jge 0x100d6236 */
            ii(0x100d_6225, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100d_6229, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100d_622c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_622e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_6232, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_6234, 2); if(jged(0x100d_6238, 0x2)) goto l_0x100d_6238; /* jge 0x100d6238 */
        l_0x100d_6236:
            ii(0x100d_6236, 2); jmpd(0x100d_6243, 0xb); goto l_0x100d_6243; /* jmp 0x100d6243 */
        l_0x100d_6238:
            ii(0x100d_6238, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100d_623c, 3); sub(eax, memd_a32[ss, ebp - 0x2c]);     /* sub eax, [ebp-0x2c] */
            ii(0x100d_623f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6241, 2); if(jld(0x100d_6245, 0x2)) goto l_0x100d_6245; /* jl 0x100d6245 */
        l_0x100d_6243:
            ii(0x100d_6243, 2); jmpd(0x100d_6256, 0x11); goto l_0x100d_6256; /* jmp 0x100d6256 */
        l_0x100d_6245:
            ii(0x100d_6245, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100d_6249, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100d_624c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_624e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_6252, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_6254, 2); if(jged(0x100d_6258, 0x2)) goto l_0x100d_6258; /* jge 0x100d6258 */
        l_0x100d_6256:
            ii(0x100d_6256, 2); jmpd(0x100d_625d, 0x5); goto l_0x100d_625d; /* jmp 0x100d625d */
        l_0x100d_6258:
            ii(0x100d_6258, 5); if(jmpd_func(0x100d_66ac, 0x44f)) return; /* jmp 0x100d66ac */
        l_0x100d_625d:
            ii(0x100d_625d, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6261, 5); calld(Definitions.sys_malloc, 0x9_4d78); /* call 0x1016afde */
            ii(0x100d_6266, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_6269, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100d_626d, 6); if(jzd_func(0x100d_66ac, 0x439)) return; /* jz 0x100d66ac */
            ii(0x100d_6273, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_6276, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100d_6279:
            ii(0x100d_6279, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_627c, 3); cmp(eax, memd_a32[ss, ebp - 0x24]);     /* cmp eax, [ebp-0x24] */
            ii(0x100d_627f, 2); if(jged(0x100d_62c8, 0x47)) goto l_0x100d_62c8; /* jge 0x100d62c8 */
            ii(0x100d_6281, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_6284, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x100d_6287, 3); add(memd_a32[ss, ebp - 0x28], eax);     /* add [ebp-0x28], eax */
            ii(0x100d_628a, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_628e, 2); if(jld(0x100d_62af, 0x1f)) goto l_0x100d_62af; /* jl 0x100d62af */
            ii(0x100d_6290, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_6293, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_6295, 3); sub(memd_a32[ss, ebp - 0x24], eax);     /* sub [ebp-0x24], eax */
            ii(0x100d_6298, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_629b, 3); sub(memd_a32[ss, ebp - 0x28], eax);     /* sub [ebp-0x28], eax */
            ii(0x100d_629e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_62a1, 3); inc(memd_a32[ss, ebp - 0x34]);          /* inc dword [ebp-0x34] */
            ii(0x100d_62a4, 3); mov(memb_a32[ds, eax], 0x1);            /* mov byte [eax], 0x1 */
            ii(0x100d_62a7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_62aa, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x100d_62ad, 2); jmpd(0x100d_62b8, 0x9); goto l_0x100d_62b8; /* jmp 0x100d62b8 */
        l_0x100d_62af:
            ii(0x100d_62af, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_62b2, 3); inc(memd_a32[ss, ebp - 0x34]);          /* inc dword [ebp-0x34] */
            ii(0x100d_62b5, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x100d_62b8:
            ii(0x100d_62b8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_62bb, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_62bd, 3); add(memd_a32[ss, ebp - 0x20], eax);     /* add [ebp-0x20], eax */
            ii(0x100d_62c0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_62c3, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x100d_62c6, 2); jmpd(0x100d_6279, -0x4f); goto l_0x100d_6279; /* jmp 0x100d6279 */
        l_0x100d_62c8:
            ii(0x100d_62c8, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x100d_62cf, 2); if(jmpd_func(0x100d_62d7, 0x6)) return; /* jmp 0x100d62d7 */
        }
    }
}
