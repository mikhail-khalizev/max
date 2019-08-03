using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("86e71b2e-e448-4ac5-9cbe-11e551bc7c40")]
        public void Method_100d_6144()
        {
            ii(0x100d_6144, 5); pushd(0x90);                            /* push 0x90 */
            ii(0x100d_6149, 5); calld(Definitions.sys_check_available_stack_size, 0x8fc04); /* call 0x10165d52 */
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
            ii(0x100d_6215, 5); jmpd(0x100d_66ac, 0x492); goto l_0x100d_66ac; /* jmp 0x100d66ac */
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
            ii(0x100d_6258, 5); jmpd(0x100d_66ac, 0x44f); goto l_0x100d_66ac; /* jmp 0x100d66ac */
        l_0x100d_625d:
            ii(0x100d_625d, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6261, 5); calld(Definitions.sys_malloc, 0x94d78); /* call 0x1016afde */
            ii(0x100d_6266, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_6269, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100d_626d, 6); if(jzd(0x100d_66ac, 0x439)) goto l_0x100d_66ac; /* jz 0x100d66ac */
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
            ii(0x100d_62cf, 2); jmpd(0x100d_62d7, 0x6); goto l_0x100d_62d7; /* jmp 0x100d62d7 */
        l_0x100d_62d1:
            ii(0x100d_62d1, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_62d4, 3); inc(memd_a32[ss, ebp - 0x38]);          /* inc dword [ebp-0x38] */
        l_0x100d_62d7:
            ii(0x100d_62d7, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x100d_62db, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100d_62de, 6); if(jged(0x100d_66a4, 0x3c0)) goto l_0x100d_66a4; /* jge 0x100d66a4 */
            ii(0x100d_62e4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_62e7, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100d_62ea, 4); mov(memb_a32[ss, ebp - 0x40], 0);       /* mov byte [ebp-0x40], 0x0 */
            ii(0x100d_62ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_62f1, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100d_62f4, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_62f7, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100d_62fa, 5); jmpd(0x100d_6524, 0x225); goto l_0x100d_6524; /* jmp 0x100d6524 */
        //  ii(0x100d_62ff, 513); Недостижимый код.
l_0x100d_6500:
            ii(0x100d_6500, 2); jmpd(0x100d_6541, 0x3f); goto l_0x100d_6541; /* jmp 0x100d6541 */
        //  ii(0x100d_6502, 34); Недостижимый код.
l_0x100d_6524:
            ii(0x100d_6524, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_6527, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100d_652a, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x7);     /* cmp word [ebp-0x6c], 0x7 */
            ii(0x100d_652f, 2); if(jad(0x100d_6500, -0x31)) goto l_0x100d_6500; /* ja 0x100d6500 */
            ii(0x100d_6531, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_6533, 4); mov(ax, memw_a32[ss, ebp - 0x6c]);      /* mov ax, [ebp-0x6c] */
            ii(0x100d_6537, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_653a, 7); jmpd_abs(memd_a32[cs, eax + 0x100d_6504]); return; /* jmp dword [cs:eax+0x100d6504] */
        l_0x100d_6541:
            ii(0x100d_6541, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x100d_6545, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6547, 2); if(jld(0x100d_6552, 0x9)) goto l_0x100d_6552; /* jl 0x100d6552 */
            ii(0x100d_6549, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_654c, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_6550, 2); if(jld(0x100d_6554, 0x2)) goto l_0x100d_6554; /* jl 0x100d6554 */
        l_0x100d_6552:
            ii(0x100d_6552, 2); jmpd(0x100d_655c, 0x8); goto l_0x100d_655c; /* jmp 0x100d655c */
        l_0x100d_6554:
            ii(0x100d_6554, 4); movsx(eax, memw_a32[ss, ebp - 0x60]);   /* movsx eax, word [ebp-0x60] */
            ii(0x100d_6558, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_655a, 2); if(jged(0x100d_655e, 0x2)) goto l_0x100d_655e; /* jge 0x100d655e */
        l_0x100d_655c:
            ii(0x100d_655c, 2); jmpd(0x100d_6567, 0x9); goto l_0x100d_6567; /* jmp 0x100d6567 */
        l_0x100d_655e:
            ii(0x100d_655e, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100d_6561, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_6565, 2); if(jld(0x100d_656c, 0x5)) goto l_0x100d_656c; /* jl 0x100d656c */
        l_0x100d_6567:
            ii(0x100d_6567, 5); jmpd(0x100d_669f, 0x133); goto l_0x100d_669f; /* jmp 0x100d669f */
        l_0x100d_656c:
            ii(0x100d_656c, 4); movsx(eax, memw_a32[ss, ebp - 0x54]);   /* movsx eax, word [ebp-0x54] */
            ii(0x100d_6570, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6572, 2); if(jld(0x100d_657d, 0x9)) goto l_0x100d_657d; /* jl 0x100d657d */
            ii(0x100d_6574, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100d_6577, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_657b, 2); if(jld(0x100d_657f, 0x2)) goto l_0x100d_657f; /* jl 0x100d657f */
        l_0x100d_657d:
            ii(0x100d_657d, 2); jmpd(0x100d_6587, 0x8); goto l_0x100d_6587; /* jmp 0x100d6587 */
        l_0x100d_657f:
            ii(0x100d_657f, 4); movsx(eax, memw_a32[ss, ebp - 0x58]);   /* movsx eax, word [ebp-0x58] */
            ii(0x100d_6583, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6585, 2); if(jged(0x100d_6589, 0x2)) goto l_0x100d_6589; /* jge 0x100d6589 */
        l_0x100d_6587:
            ii(0x100d_6587, 2); jmpd(0x100d_6592, 0x9); goto l_0x100d_6592; /* jmp 0x100d6592 */
        l_0x100d_6589:
            ii(0x100d_6589, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100d_658c, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_6590, 2); if(jld(0x100d_65df, 0x4d)) goto l_0x100d_65df; /* jl 0x100d65df */
        l_0x100d_6592:
            ii(0x100d_6592, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_6595, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_6598, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100d_659b, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_659f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65a1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e6c]); /* mov ax, [eax+0x101b7e6c] */
            ii(0x100d_65a8, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100d_65ab, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65af, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65b1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e6e]); /* mov ax, [eax+0x101b7e6e] */
            ii(0x100d_65b8, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100d_65bb, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65bf, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65c1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e70]); /* mov ax, [eax+0x101b7e70] */
            ii(0x100d_65c8, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100d_65cb, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65cf, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65d1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e72]); /* mov ax, [eax+0x101b7e72] */
            ii(0x100d_65d8, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100d_65db, 4); mov(memb_a32[ss, ebp - 0x40], 0x1);     /* mov byte [ebp-0x40], 0x1 */
        l_0x100d_65df:
            ii(0x100d_65df, 4); movsx(edx, memw_a32[ss, ebp - 0x50]);   /* movsx edx, word [ebp-0x50] */
            ii(0x100d_65e3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_65e7, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_65ea, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_65ee, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_65f0, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_65f3, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_65f6, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100d_65f9:
            ii(0x100d_65f9, 3); dec(memd_a32[ss, ebp - 0x3c]);          /* dec dword [ebp-0x3c] */
            ii(0x100d_65fc, 5); cmp(memw_a32[ss, ebp - 0x3c], -0x1 /* 0xff */); /* cmp word [ebp-0x3c], 0xffff */
            ii(0x100d_6601, 6); if(jzd(0x100d_669f, 0x98)) goto l_0x100d_669f; /* jz 0x100d669f */
            ii(0x100d_6607, 4); cmp(memb_a32[ss, ebp - 0x40], 0);       /* cmp byte [ebp-0x40], 0x0 */
            ii(0x100d_660b, 2); if(jnzd(0x100d_6636, 0x29)) goto l_0x100d_6636; /* jnz 0x100d6636 */
            ii(0x100d_660d, 3); mov(al, memb_a32[ss, ebp + 0x1c]);      /* mov al, [ebp+0x1c] */
            ii(0x100d_6610, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x100d_6613, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x100d_6615, 4); movsx(eax, memw_a32[ss, ebp - 0x64]);   /* movsx eax, word [ebp-0x64] */
            ii(0x100d_6619, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_661c, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_661f, 3); inc(memd_a32[ss, ebp - 0x34]);          /* inc dword [ebp-0x34] */
            ii(0x100d_6622, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_6625, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100d_6628, 2); if(jzd(0x100d_6631, 0x7)) goto l_0x100d_6631; /* jz 0x100d6631 */
            ii(0x100d_662a, 4); movsx(eax, memw_a32[ss, ebp - 0x68]);   /* movsx eax, word [ebp-0x68] */
            ii(0x100d_662e, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
        l_0x100d_6631:
            ii(0x100d_6631, 5); jmpd(0x100d_669a, 0x64); goto l_0x100d_669a; /* jmp 0x100d669a */
        l_0x100d_6636:
            ii(0x100d_6636, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_663a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_663c, 2); if(jld(0x100d_6647, 0x9)) goto l_0x100d_6647; /* jl 0x100d6647 */
            ii(0x100d_663e, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_6641, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_6645, 2); if(jld(0x100d_6649, 0x2)) goto l_0x100d_6649; /* jl 0x100d6649 */
        l_0x100d_6647:
            ii(0x100d_6647, 2); jmpd(0x100d_6651, 0x8); goto l_0x100d_6651; /* jmp 0x100d6651 */
        l_0x100d_6649:
            ii(0x100d_6649, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x100d_664d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_664f, 2); if(jged(0x100d_6653, 0x2)) goto l_0x100d_6653; /* jge 0x100d6653 */
        l_0x100d_6651:
            ii(0x100d_6651, 2); jmpd(0x100d_665c, 0x9); goto l_0x100d_665c; /* jmp 0x100d665c */
        l_0x100d_6653:
            ii(0x100d_6653, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100d_6656, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_665a, 2); if(jld(0x100d_665e, 0x2)) goto l_0x100d_665e; /* jl 0x100d665e */
        l_0x100d_665c:
            ii(0x100d_665c, 2); jmpd(0x100d_6666, 0x8); goto l_0x100d_6666; /* jmp 0x100d6666 */
        l_0x100d_665e:
            ii(0x100d_665e, 3); mov(al, memb_a32[ss, ebp + 0x1c]);      /* mov al, [ebp+0x1c] */
            ii(0x100d_6661, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x100d_6664, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
        l_0x100d_6666:
            ii(0x100d_6666, 4); movsx(eax, memw_a32[ss, ebp - 0x64]);   /* movsx eax, word [ebp-0x64] */
            ii(0x100d_666a, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_666d, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x100d_6670, 3); add(memd_a32[ss, ebp - 0x4c], eax);     /* add [ebp-0x4c], eax */
            ii(0x100d_6673, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x100d_6676, 3); add(memd_a32[ss, ebp - 0x50], eax);     /* add [ebp-0x50], eax */
            ii(0x100d_6679, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_667c, 3); inc(memd_a32[ss, ebp - 0x34]);          /* inc dword [ebp-0x34] */
            ii(0x100d_667f, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_6682, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100d_6685, 2); if(jzd(0x100d_669a, 0x13)) goto l_0x100d_669a; /* jz 0x100d669a */
            ii(0x100d_6687, 4); movsx(eax, memw_a32[ss, ebp - 0x68]);   /* movsx eax, word [ebp-0x68] */
            ii(0x100d_668b, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_668e, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100d_6691, 3); add(memd_a32[ss, ebp - 0x4c], eax);     /* add [ebp-0x4c], eax */
            ii(0x100d_6694, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100d_6697, 3); add(memd_a32[ss, ebp - 0x50], eax);     /* add [ebp-0x50], eax */
        l_0x100d_669a:
            ii(0x100d_669a, 5); jmpd(0x100d_65f9, -0xa6); goto l_0x100d_65f9; /* jmp 0x100d65f9 */
        l_0x100d_669f:
            ii(0x100d_669f, 5); jmpd(0x100d_62d1, -0x3d3); goto l_0x100d_62d1; /* jmp 0x100d62d1 */
        l_0x100d_66a4:
            ii(0x100d_66a4, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_66a7, 5); calld(Definitions.sys_free, 0x94a15);   /* call 0x1016b0c1 */
        l_0x100d_66ac:
            ii(0x100d_66ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_66ae, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_66af, 1); popd(edi);                              /* pop edi */
            ii(0x100d_66b0, 1); popd(esi);                              /* pop esi */
            ii(0x100d_66b1, 3); retd(0x10); return;                     /* ret 0x10 */
        }
    }
}
