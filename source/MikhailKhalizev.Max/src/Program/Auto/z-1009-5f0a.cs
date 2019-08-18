using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_5f0a-c2391856")]
        public void Method_1009_5f0a()
        {
            ii(0x1009_5f0a, 5); pushd(0x84);                            /* push 0x84 */
            ii(0x1009_5f0f, 5); calld(Definitions.sys_check_available_stack_size, 0xc_fe3e); /* call 0x10165d52 */
            ii(0x1009_5f14, 1); pushd(esi);                             /* push esi */
            ii(0x1009_5f15, 1); pushd(edi);                             /* push edi */
            ii(0x1009_5f16, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_5f17, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_5f19, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1009_5f1f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_5f22, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_5f25, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1009_5f28, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1009_5f2b, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_5f30, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5f33, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_5f35, 2); if(jnzd(0x1009_5f40, 0x9)) goto l_0x1009_5f40; /* jnz 0x10095f40 */
            ii(0x1009_5f37, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_5f3b, 5); jmpd(0x1009_6254, 0x314); goto l_0x1009_6254; /* jmp 0x10096254 */
        l_0x1009_5f40:
            ii(0x1009_5f40, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5f43, 5); calld(0x1009_0b73, -0x53d5);            /* call 0x10090b73 */
            ii(0x1009_5f48, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1009_5f4b, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1009_5f4f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5f52, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_f467); /* call 0x10076af0 */
            ii(0x1009_5f57, 4); or(memb_a32[ss, ebp - 0x18], 0x1);      /* or byte [ebp-0x18], 0x1 */
            ii(0x1009_5f5b, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_5f5e, 5); calld(0x1008_bbed, -0xa376);            /* call 0x1008bbed */
            ii(0x1009_5f63, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1009_5f66, 4); and(memb_a32[ss, ebp - 0x18], -0x2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x1009_5f6a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5f6d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_5f70, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5f73, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1009_5f79, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1009_5f7e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_5f80, 5); calld(0x1009_c864, 0x68df);             /* call 0x1009c864 */
            ii(0x1009_5f85, 3); lea(ebx, ebp - 0x40);                   /* lea ebx, [ebp-0x40] */
            ii(0x1009_5f88, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5f8a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_5f8c, 5); calld(0x1007_5e64, -0x2_012d);          /* call 0x10075e64 */
            ii(0x1009_5f91, 5); calld(0x100e_a7e7, 0x5_4851);           /* call 0x100ea7e7 */
            ii(0x1009_5f96, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1009_5f9a, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5f9b, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x1009_5f9e, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_5fa1, 5); calld(0x1008_a6f8, -0xb8ae);            /* call 0x1008a6f8 */
            ii(0x1009_5fa6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_5fa8, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1009_5fab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5fae, 5); calld(0x1009_5947, -0x66c);             /* call 0x10095947 */
            ii(0x1009_5fb3, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1009_5fb6, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1009_5fb9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5fbc, 5); calld(0x1009_1245, -0x4d7c);            /* call 0x10091245 */
            ii(0x1009_5fc1, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1009_5fc5, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5fc6, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_5fca, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1009_5fcd, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1009_5fd0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5fd3, 5); calld(0x1009_177d, -0x485b);            /* call 0x1009177d */
            ii(0x1009_5fd8, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_5fdd, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1009_5fe0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5fe3, 5); calld(0x1009_2139, -0x3eaf);            /* call 0x10092139 */
            ii(0x1009_5fe8, 5); calld(0x100e_a7e7, 0x5_47fa);           /* call 0x100ea7e7 */
            ii(0x1009_5fed, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1009_5ff1, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5ff2, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x1009_5ff5, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1009_5ff9, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_5ffc, 5); calld(0x1008_a6f8, -0xb909);            /* call 0x1008a6f8 */
            ii(0x1009_6001, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6003, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6006, 5); calld(0x1009_5cb1, -0x35a);             /* call 0x10095cb1 */
            ii(0x1009_600b, 5); cmp(memw_a32[ss, ebp - 0x4], 0x22);     /* cmp word [ebp-0x4], 0x22 */
            ii(0x1009_6010, 2); if(jzd(0x1009_6019, 0x7)) goto l_0x1009_6019; /* jz 0x10096019 */
            ii(0x1009_6012, 5); cmp(memw_a32[ss, ebp - 0x4], 0x24);     /* cmp word [ebp-0x4], 0x24 */
            ii(0x1009_6017, 2); if(jnzd(0x1009_6038, 0x1f)) goto l_0x1009_6038; /* jnz 0x10096038 */
        l_0x1009_6019:
            ii(0x1009_6019, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1009_601d, 1); pushd(eax);                             /* push eax */
            ii(0x1009_601e, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x1009_6021, 5); mov(ebx, 0x25);                         /* mov ebx, 0x25 */
            ii(0x1009_6026, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_6029, 5); calld(0x1008_a6f8, -0xb936);            /* call 0x1008a6f8 */
            ii(0x1009_602e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6030, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6033, 5); calld(0x1009_5cb1, -0x387);             /* call 0x10095cb1 */
        l_0x1009_6038:
            ii(0x1009_6038, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1009_603c, 7); mov(memd_a32[ss, ebp - 0x28], 0x1);     /* mov dword [ebp-0x28], 0x1 */
            ii(0x1009_6043, 6); mov(memw_a32[ss, ebp - 0x30], 0x1);     /* mov word [ebp-0x30], 0x1 */
            ii(0x1009_6049, 2); jmpd(0x1009_6052, 0x7); goto l_0x1009_6052; /* jmp 0x10096052 */
        l_0x1009_604b:
            ii(0x1009_604b, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_604e, 4); inc(memw_a32[ss, ebp - 0x30]);          /* inc word [ebp-0x30] */
        l_0x1009_6052:
            ii(0x1009_6052, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_6057, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_605a, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x1009_605e, 1); dec(eax);                               /* dec eax */
            ii(0x1009_605f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_6061, 6); if(jged(0x1009_6150, 0xe9)) goto l_0x1009_6150; /* jge 0x10096150 */
            ii(0x1009_6067, 6); mov(memw_a32[ss, ebp - 0x2e], 0x1);     /* mov word [ebp-0x2e], 0x1 */
            ii(0x1009_606d, 2); jmpd(0x1009_6076, 0x7); goto l_0x1009_6076; /* jmp 0x10096076 */
        l_0x1009_606f:
            ii(0x1009_606f, 3); mov(eax, memd_a32[ss, ebp - 0x2e]);     /* mov eax, [ebp-0x2e] */
            ii(0x1009_6072, 4); inc(memw_a32[ss, ebp - 0x2e]);          /* inc word [ebp-0x2e] */
        l_0x1009_6076:
            ii(0x1009_6076, 4); movsx(edx, memw_a32[ss, ebp - 0x2e]);   /* movsx edx, word [ebp-0x2e] */
            ii(0x1009_607a, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_607f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_6082, 1); dec(eax);                               /* dec eax */
            ii(0x1009_6083, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_6085, 6); if(jged(0x1009_614b, 0xc0)) goto l_0x1009_614b; /* jge 0x1009614b */
            ii(0x1009_608b, 4); movsx(ebx, memw_a32[ss, ebp - 0x2e]);   /* movsx ebx, word [ebp-0x2e] */
            ii(0x1009_608f, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x1009_6093, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_6096, 5); calld(0x1008_a728, -0xb973);            /* call 0x1008a728 */
            ii(0x1009_609b, 3); lea(edx, eax + ebx);                    /* lea edx, [eax+ebx] */
            ii(0x1009_609e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_60a0, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1009_60a2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_60a5, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_60a8, 4); cmp(ax, memw_a32[ss, ebp - 0x28]);      /* cmp ax, [ebp-0x28] */
            ii(0x1009_60ac, 2); if(jld(0x1009_60ca, 0x1c)) goto l_0x1009_60ca; /* jl 0x100960ca */
            ii(0x1009_60ae, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1009_60b2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_60b5, 3); add(eax, memd_a32[ss, ebp - 0x2c]);     /* add eax, [ebp-0x2c] */
            ii(0x1009_60b8, 4); movsx(edx, memw_a32[ss, ebp - 0x2e]);   /* movsx edx, word [ebp-0x2e] */
            ii(0x1009_60bc, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_60be, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_60c0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_60c2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_60c5, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_60c8, 2); if(jld(0x1009_60cf, 0x5)) goto l_0x1009_60cf; /* jl 0x100960cf */
        l_0x1009_60ca:
            ii(0x1009_60ca, 5); jmpd(0x1009_6146, 0x77); goto l_0x1009_6146; /* jmp 0x10096146 */
        l_0x1009_60cf:
            ii(0x1009_60cf, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1009_60d2, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1009_60d5, 5); calld(0x1007_5e64, -0x2_0276);          /* call 0x10075e64 */
            ii(0x1009_60da, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_60dc, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1009_60df, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1009_60e2, 5); calld(0x1007_5e64, -0x2_0283);          /* call 0x10075e64 */
            ii(0x1009_60e7, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_60e9, 5); calld(0x100a_5fca, 0xfedc);             /* call 0x100a5fca */
            ii(0x1009_60ee, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1009_60f1, 4); cmp(memb_a32[ss, ebp - 0x1c], 0);       /* cmp byte [ebp-0x1c], 0x0 */
            ii(0x1009_60f5, 2); if(jzd(0x1009_6100, 0x9)) goto l_0x1009_6100; /* jz 0x10096100 */
            ii(0x1009_60f7, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_60fa, 4); cmp(ax, memw_a32[ss, ebp - 0x28]);      /* cmp ax, [ebp-0x28] */
            ii(0x1009_60fe, 2); if(jled(0x1009_6102, 0x2)) goto l_0x1009_6102; /* jle 0x10096102 */
        l_0x1009_6100:
            ii(0x1009_6100, 2); jmpd(0x1009_610b, 0x9); goto l_0x1009_610b; /* jmp 0x1009610b */
        l_0x1009_6102:
            ii(0x1009_6102, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1009_6105, 4); cmp(ax, memw_a32[ss, ebp - 0x20]);      /* cmp ax, [ebp-0x20] */
            ii(0x1009_6109, 2); if(jged(0x1009_6146, 0x3b)) goto l_0x1009_6146; /* jge 0x10096146 */
        l_0x1009_610b:
            ii(0x1009_610b, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_610f, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1009_6112, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1009_6115, 5); calld(0x1007_5e64, -0x2_02b6);          /* call 0x10075e64 */
            ii(0x1009_611a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_611c, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1009_611f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6122, 5); calld(0x1009_285c, -0x38cb);            /* call 0x1009285c */
            ii(0x1009_6127, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6129, 2); if(jzd(0x1009_6146, 0x1b)) goto l_0x1009_6146; /* jz 0x10096146 */
            ii(0x1009_612b, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1009_612e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_6131, 5); calld(0x1008_8b44, -0xd5f2);            /* call 0x10088b44 */
            ii(0x1009_6136, 4); mov(memb_a32[ss, ebp - 0x1c], 0x1);     /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1009_613a, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1009_613d, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_6140, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_6143, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1009_6146:
            ii(0x1009_6146, 5); jmpd(0x1009_606f, -0xdc); goto l_0x1009_606f; /* jmp 0x1009606f */
        l_0x1009_614b:
            ii(0x1009_614b, 5); jmpd(0x1009_604b, -0x105); goto l_0x1009_604b; /* jmp 0x1009604b */
        l_0x1009_6150:
            ii(0x1009_6150, 4); cmp(memb_a32[ss, ebp - 0x1c], 0);       /* cmp byte [ebp-0x1c], 0x0 */
            ii(0x1009_6154, 6); if(jzd(0x1009_622d, 0xd3)) goto l_0x1009_622d; /* jz 0x1009622d */
            ii(0x1009_615a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_615d, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1009_6161, 1); inc(eax);                               /* inc eax */
            ii(0x1009_6162, 1); cwde();                                 /* cwde */
            ii(0x1009_6163, 1); pushd(eax);                             /* push eax */
            ii(0x1009_6164, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_6167, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_616a, 1); inc(eax);                               /* inc eax */
            ii(0x1009_616b, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_616e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_6171, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1009_6173, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_6176, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_6179, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1009_617c, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1009_617f, 5); calld(0x1008_b148, -0xb03c);            /* call 0x1008b148 */
            ii(0x1009_6184, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6187, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_618a, 5); calld(0x1009_c6c8, 0x6539);             /* call 0x1009c6c8 */
            ii(0x1009_618f, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x1009_6192, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6194, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_6196, 5); calld(0x1009_c5dc, 0x6441);             /* call 0x1009c5dc */
            ii(0x1009_619b, 2); jmpd(0x1009_61a5, 0x8); goto l_0x1009_61a5; /* jmp 0x100961a5 */
        l_0x1009_619d:
            ii(0x1009_619d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_61a0, 5); calld(0x1007_6bf8, -0x1_f5ad);          /* call 0x10076bf8 */
        l_0x1009_61a5:
            ii(0x1009_61a5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_61a7, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_61aa, 5); calld(0x1013_ad71, 0xa_4bc2);           /* call 0x1013ad71 */
            ii(0x1009_61af, 2); test(al, al);                           /* test al, al */
            ii(0x1009_61b1, 6); if(jzd(0x1009_6223, 0x6c)) goto l_0x1009_6223; /* jz 0x10096223 */
            ii(0x1009_61b7, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_61ba, 5); calld(0x1009_c4f8, 0x6339);             /* call 0x1009c4f8 */
            ii(0x1009_61bf, 5); calld(0x1009_c4c4, 0x6300);             /* call 0x1009c4c4 */
            ii(0x1009_61c4, 4); cmp(ax, 0x27);                          /* cmp ax, 0x27 */
            ii(0x1009_61c8, 2); if(jnzd(0x1009_61e5, 0x1b)) goto l_0x1009_61e5; /* jnz 0x100961e5 */
            ii(0x1009_61ca, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_61cd, 5); calld(0x1009_c4f8, 0x6326);             /* call 0x1009c4f8 */
            ii(0x1009_61d2, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1009_61d5, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1009_61d8, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_61db, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1009_61de, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_61e1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_61e3, 2); if(jzd(0x1009_61e7, 0x2)) goto l_0x1009_61e7; /* jz 0x100961e7 */
        l_0x1009_61e5:
            ii(0x1009_61e5, 2); jmpd(0x1009_6205, 0x1e); goto l_0x1009_6205; /* jmp 0x10096205 */
        l_0x1009_61e7:
            ii(0x1009_61e7, 3); lea(edx, ebp - 0x6c);                   /* lea edx, [ebp-0x6c] */
            ii(0x1009_61ea, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_61ed, 5); calld(0x1009_c4f8, 0x6306);             /* call 0x1009c4f8 */
            ii(0x1009_61f2, 5); calld(0x100a_2d3d, 0xcb46);             /* call 0x100a2d3d */
            ii(0x1009_61f7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_61f9, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1009_61fc, 5); calld(0x1010_82ce, 0x7_20cd);           /* call 0x101082ce */
            ii(0x1009_6201, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6203, 2); if(jnzd(0x1009_6207, 0x2)) goto l_0x1009_6207; /* jnz 0x10096207 */
        l_0x1009_6205:
            ii(0x1009_6205, 2); jmpd(0x1009_621e, 0x17); goto l_0x1009_621e; /* jmp 0x1009621e */
        l_0x1009_6207:
            ii(0x1009_6207, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_620a, 5); calld(0x1009_c4f8, 0x62e9);             /* call 0x1009c4f8 */
            ii(0x1009_620f, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x1009_6212, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1009_6215, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_6218, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1009_621b, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
        l_0x1009_621e:
            ii(0x1009_621e, 5); jmpd(0x1009_619d, -0x86); goto l_0x1009_619d; /* jmp 0x1009619d */
        l_0x1009_6223:
            ii(0x1009_6223, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6225, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_6228, 5); calld(0x1009_ba6c, 0x583f);             /* call 0x1009ba6c */
        l_0x1009_622d:
            ii(0x1009_622d, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1009_6230, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6233, 5); calld(0x1009_0c0d, -0x562b);            /* call 0x10090c0d */
            ii(0x1009_6238, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x1009_623b, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1009_623e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6240, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_6243, 5); calld(0x1008_bc9f, -0xa5a9);            /* call 0x1008bc9f */
            ii(0x1009_6248, 2); jmpd(0x1009_6254, 0xa); goto l_0x1009_6254; /* jmp 0x10096254 */
        //    ii(0x1009_624a, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_624c, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
        //    ii(0x1009_624f, 5); calld(0x1008_bc9f, -0xa5b5);            /* call 0x1008bc9f */
        l_0x1009_6254:
            ii(0x1009_6254, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_6257, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_6259, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_625a, 1); popd(edi);                              /* pop edi */
            ii(0x1009_625b, 1); popd(esi);                              /* pop esi */
            ii(0x1009_625c, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
