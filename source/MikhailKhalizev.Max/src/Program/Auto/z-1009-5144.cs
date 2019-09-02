using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_5144-1473a7cb")]
        public void Method_1009_5144()
        {
            ii(0x1009_5144, 5); push(0x60);                             /* push 0x60 */
            ii(0x1009_5149, 5); call(Definitions.sys_check_available_stack_size, 0xd_0c04); /* call 0x10165d52 */
            ii(0x1009_514e, 1); push(ecx);                              /* push ecx */
            ii(0x1009_514f, 1); push(esi);                              /* push esi */
            ii(0x1009_5150, 1); push(edi);                              /* push edi */
            ii(0x1009_5151, 1); push(ebp);                              /* push ebp */
            ii(0x1009_5152, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_5154, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1009_515a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_515d, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_5160, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_5163, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_5166, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_5169, 5); call(0x1007_6338, -0x1_ee36);           /* call 0x10076338 */
            ii(0x1009_516e, 3); lea(ecx, memd[ss, ebp - 0x18]);         /* lea ecx, [ebp-0x18] */
            ii(0x1009_5171, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5173, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1009_5175, 5); call(0x1007_64b8, -0x1_ecc2);           /* call 0x100764b8 */
            ii(0x1009_517a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_517d, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1009_5181, 7); add(ax, memw[ds, 0x101c_8174]);         /* add ax, [0x101c8174] */
            ii(0x1009_5188, 1); cwde();                                 /* cwde */
            ii(0x1009_5189, 1); push(eax);                              /* push eax */
            ii(0x1009_518a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_518d, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1009_5191, 7); add(ax, memw[ds, 0x101c_8172]);         /* add ax, [0x101c8172] */
            ii(0x1009_5198, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_519b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_519e, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x1009_51a2, 7); sub(ax, memw[ds, 0x101c_8174]);         /* sub ax, [0x101c8174] */
            ii(0x1009_51a9, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_51ac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_51af, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_51b2, 7); sub(ax, memw[ds, 0x101c_8172]);         /* sub ax, [0x101c8172] */
            ii(0x1009_51b9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_51bc, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_51bf, 5); call(0x1008_b148, -0xa07c);             /* call 0x1008b148 */
            ii(0x1009_51c4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_51c6, 1); push(eax);                              /* push eax */
            ii(0x1009_51c7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_51c9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_51cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_51cd, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1009_51d0, 5); call(0x1008_b148, -0xa08d);             /* call 0x1008b148 */
            ii(0x1009_51d5, 2); jmp(0x1009_51df, 8); goto l_0x1009_51df; /* jmp 0x100951df */
        l_0x1009_51d7:
            ii(0x1009_51d7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_51da, 5); call(0x1007_6bf8, -0x1_e5e7);           /* call 0x10076bf8 */
        l_0x1009_51df:
            ii(0x1009_51df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_51e1, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_51e4, 5); call(0x1013_ad71, 0xa_5b88);            /* call 0x1013ad71 */
            ii(0x1009_51e9, 2); test(al, al);                           /* test al, al */
            ii(0x1009_51eb, 2); if(jz(0x1009_520d, 0x20)) goto l_0x1009_520d; /* jz 0x1009520d */
            ii(0x1009_51ed, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1009_51f0, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_51f3, 5); call(0x1007_63a0, -0x1_ee58);           /* call 0x100763a0 */
            ii(0x1009_51f8, 5); call(0x1015_2532, 0xb_d335);            /* call 0x10152532 */
            ii(0x1009_51fd, 3); lea(ebx, memd[ss, ebp - 0x28]);         /* lea ebx, [ebp-0x28] */
            ii(0x1009_5200, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1009_5203, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5206, 5); call(0x1009_4ee8, -0x323);              /* call 0x10094ee8 */
            ii(0x1009_520b, 2); jmp(0x1009_51d7, -0x36); goto l_0x1009_51d7; /* jmp 0x100951d7 */
        l_0x1009_520d:
            ii(0x1009_520d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_5210, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_5213, 5); call(0x1009_c6c8, 0x74b0);              /* call 0x1009c6c8 */
            ii(0x1009_5218, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x1009_521b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_521d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_521f, 5); call(0x1009_c5dc, 0x73b8);              /* call 0x1009c5dc */
            ii(0x1009_5224, 2); jmp(0x1009_522e, 8); goto l_0x1009_522e; /* jmp 0x1009522e */
        l_0x1009_5226:
            ii(0x1009_5226, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_5229, 5); call(0x1007_6bf8, -0x1_e636);           /* call 0x10076bf8 */
        l_0x1009_522e:
            ii(0x1009_522e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5230, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_5233, 5); call(0x1013_ad71, 0xa_5b39);            /* call 0x1013ad71 */
            ii(0x1009_5238, 2); test(al, al);                           /* test al, al */
            ii(0x1009_523a, 2); if(jz(0x1009_5281, 0x45)) goto l_0x1009_5281; /* jz 0x10095281 */
            ii(0x1009_523c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_523f, 5); call(0x1009_c4f8, 0x72b4);              /* call 0x1009c4f8 */
            ii(0x1009_5244, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1009_5247, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1009_524a, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1009_524d, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1009_5250, 3); call_abs(memd[ds, edx + 0x74]);         /* call dword [edx+0x74] */
            ii(0x1009_5253, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5255, 2); if(jz(0x1009_527f, 0x28)) goto l_0x1009_527f; /* jz 0x1009527f */
            ii(0x1009_5257, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_525a, 5); call(0x1009_c4f8, 0x7299);              /* call 0x1009c4f8 */
            ii(0x1009_525f, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1009_5262, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_5265, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1009_5268, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1009_526b, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_526e, 3); call_abs(memd[ds, ebx + 0x1c]);         /* call dword [ebx+0x1c] */
            ii(0x1009_5271, 3); lea(ebx, memd[ss, ebp - 0x28]);         /* lea ebx, [ebp-0x28] */
            ii(0x1009_5274, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1009_5277, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_527a, 5); call(0x1009_4ee8, -0x397);              /* call 0x10094ee8 */
        l_0x1009_527f:
            ii(0x1009_527f, 2); jmp(0x1009_5226, -0x5b); goto l_0x1009_5226; /* jmp 0x10095226 */
        l_0x1009_5281:
            ii(0x1009_5281, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5284, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_5287, 3); sub(eax, memd[ss, ebp - 0x28]);         /* sub eax, [ebp-0x28] */
            ii(0x1009_528a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_528d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5290, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_5293, 3); sub(edx, memd[ds, eax + 8]);            /* sub edx, [eax+0x8] */
            ii(0x1009_5296, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_5298, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_529c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_529e, 2); if(jle(0x1009_52ad, 0xd)) goto l_0x1009_52ad; /* jle 0x100952ad */
            ii(0x1009_52a0, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_52a3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_52a6, 4); sub(ax, memw[ds, edx + 8]);             /* sub ax, [edx+0x8] */
            ii(0x1009_52aa, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1009_52ad:
            ii(0x1009_52ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_52b0, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1009_52b3, 3); sub(eax, memd[ss, ebp - 0x24]);         /* sub eax, [ebp-0x24] */
            ii(0x1009_52b6, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_52ba, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_52bc, 2); if(jle(0x1009_52cb, 0xd)) goto l_0x1009_52cb; /* jle 0x100952cb */
            ii(0x1009_52be, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_52c1, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x1009_52c5, 3); sub(eax, memd[ss, ebp - 0x24]);         /* sub eax, [ebp-0x24] */
            ii(0x1009_52c8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1009_52cb:
            ii(0x1009_52cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_52ce, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1009_52d1, 3); sub(edx, memd[ds, eax + 0xc]);          /* sub edx, [eax+0xc] */
            ii(0x1009_52d4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_52d6, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_52da, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_52dc, 2); if(jle(0x1009_52eb, 0xd)) goto l_0x1009_52eb; /* jle 0x100952eb */
            ii(0x1009_52de, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_52e1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_52e4, 4); sub(ax, memw[ds, edx + 0xc]);           /* sub ax, [edx+0xc] */
            ii(0x1009_52e8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1009_52eb:
            ii(0x1009_52eb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_52ee, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1009_52f1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_52f4, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1009_52fb, 2); if(jge(0x1009_5305, 8)) goto l_0x1009_5305; /* jge 0x10095305 */
            ii(0x1009_52fd, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_5301, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_5303, 2); if(jg(0x1009_531e, 0x19)) goto l_0x1009_531e; /* jg 0x1009531e */
        l_0x1009_5305:
            ii(0x1009_5305, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5307, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_530a, 5); call(0x1009_ba6c, 0x675d);              /* call 0x1009ba6c */
            ii(0x1009_530f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5311, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_5314, 5); call(0x1007_5f6c, -0x1_f3ad);           /* call 0x10075f6c */
            ii(0x1009_5319, 5); jmp(0x1009_545c, 0x13e); goto l_0x1009_545c; /* jmp 0x1009545c */
        l_0x1009_531e:
            ii(0x1009_531e, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1009_5324, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_5327, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_5329, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_532c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_532e, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1009_5330, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_5334, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_5336, 2); if(jge(0x1009_5341, 9)) goto l_0x1009_5341; /* jge 0x10095341 */
            ii(0x1009_5338, 7); mov(memd[ss, ebp - 0x44], 0);           /* mov dword [ebp-0x44], 0x0 */
            ii(0x1009_533f, 2); jmp(0x1009_535a, 0x19); goto l_0x1009_535a; /* jmp 0x1009535a */
        l_0x1009_5341:
            ii(0x1009_5341, 5); mov(ecx, 0xe43);                        /* mov ecx, 0xe43 */
            ii(0x1009_5346, 5); mov(ebx, StringDefinitions.AiBuildCpp6); /* mov ebx, 0x101a0603 */
            ii(0x1009_534b, 5); mov(edx, StringDefinitions.DistanceLessMapxdim2); /* mov edx, 0x101a0610 */
            ii(0x1009_5350, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_5352, 5); call(Definitions.sys_assert, 0xd_0a3b); /* call 0x10165d92 */
            ii(0x1009_5357, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
        l_0x1009_535a:
            ii(0x1009_535a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_535d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_535f, 3); sub(eax, memd[ss, ebp - 0x28]);         /* sub eax, [ebp-0x28] */
            ii(0x1009_5362, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_5366, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_5368, 2); if(jl(0x1009_5393, 0x29)) goto l_0x1009_5393; /* jl 0x10095393 */
            ii(0x1009_536a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_536d, 1); push(eax);                              /* push eax */
            ii(0x1009_536e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5371, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x1009_5374, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5377, 1); push(eax);                              /* push eax */
            ii(0x1009_5378, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_537b, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x1009_537e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5381, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1009_5384, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_5387, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1009_538b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_538e, 5); call(0x1009_4fea, -0x3a9);              /* call 0x10094fea */
        l_0x1009_5393:
            ii(0x1009_5393, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5396, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_5399, 3); sub(edx, memd[ds, eax + 8]);            /* sub edx, [eax+0x8] */
            ii(0x1009_539c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_539e, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_53a2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_53a4, 2); if(jl(0x1009_53d2, 0x2c)) goto l_0x1009_53d2; /* jl 0x100953d2 */
            ii(0x1009_53a6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_53a9, 1); push(eax);                              /* push eax */
            ii(0x1009_53aa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_53ad, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x1009_53b0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_53b3, 1); push(eax);                              /* push eax */
            ii(0x1009_53b4, 4); movsx(ecx, memw[ss, ebp - 0x20]);       /* movsx ecx, word [ebp-0x20] */
            ii(0x1009_53b8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_53bb, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1009_53be, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_53c1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_53c4, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1009_53c7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_53ca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_53cd, 5); call(0x1009_4fea, -0x3e8);              /* call 0x10094fea */
        l_0x1009_53d2:
            ii(0x1009_53d2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_53d5, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1009_53d8, 3); sub(eax, memd[ss, ebp - 0x24]);         /* sub eax, [ebp-0x24] */
            ii(0x1009_53db, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_53df, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_53e1, 2); if(jl(0x1009_540c, 0x29)) goto l_0x1009_540c; /* jl 0x1009540c */
            ii(0x1009_53e3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_53e6, 1); push(eax);                              /* push eax */
            ii(0x1009_53e7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_53ea, 3); mov(eax, memd[ds, eax + 2]);            /* mov eax, [eax+0x2] */
            ii(0x1009_53ed, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_53f0, 1); push(eax);                              /* push eax */
            ii(0x1009_53f1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_53f4, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x1009_53f7, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_53fa, 4); movsx(ebx, memw[ss, ebp - 0x24]);       /* movsx ebx, word [ebp-0x24] */
            ii(0x1009_53fe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5401, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1009_5404, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_5407, 5); call(0x1009_4fea, -0x422);              /* call 0x10094fea */
        l_0x1009_540c:
            ii(0x1009_540c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_540f, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1009_5412, 3); sub(edx, memd[ds, eax + 0xc]);          /* sub edx, [eax+0xc] */
            ii(0x1009_5415, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_5417, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_541b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_541d, 2); if(jl(0x1009_5448, 0x29)) goto l_0x1009_5448; /* jl 0x10095448 */
            ii(0x1009_541f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_5422, 1); push(eax);                              /* push eax */
            ii(0x1009_5423, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_5427, 1); push(eax);                              /* push eax */
            ii(0x1009_5428, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_542b, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x1009_542e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_5431, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_5434, 3); mov(ebx, memd[ds, eax + 0xa]);          /* mov ebx, [eax+0xa] */
            ii(0x1009_5437, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_543a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_543d, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1009_5440, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_5443, 5); call(0x1009_4fea, -0x45e);              /* call 0x10094fea */
        l_0x1009_5448:
            ii(0x1009_5448, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_544a, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_544d, 5); call(0x1009_ba6c, 0x661a);              /* call 0x1009ba6c */
            ii(0x1009_5452, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5454, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_5457, 5); call(0x1007_5f6c, -0x1_f4f0);           /* call 0x10075f6c */
        l_0x1009_545c:
            ii(0x1009_545c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_545e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_545f, 1); pop(edi);                               /* pop edi */
            ii(0x1009_5460, 1); pop(esi);                               /* pop esi */
            ii(0x1009_5461, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_5462, 1); ret();                                  /* ret */
        }
    }
}
