using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_5ed9-9f37c1af")]
        public void Method_100c_5ed9()
        {
            ii(0x100c_5ed9, 5); push(0x38);                             /* push 0x38 */
            ii(0x100c_5ede, 5); call(Definitions.sys_check_available_stack_size, 0x9_fe6f); /* call 0x10165d52 */
            ii(0x100c_5ee3, 1); push(ebx);                              /* push ebx */
            ii(0x100c_5ee4, 1); push(ecx);                              /* push ecx */
            ii(0x100c_5ee5, 1); push(esi);                              /* push esi */
            ii(0x100c_5ee6, 1); push(edi);                              /* push edi */
            ii(0x100c_5ee7, 1); push(ebp);                              /* push ebp */
            ii(0x100c_5ee8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_5eea, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_5ef0, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_5ef3, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_5ef6, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_5efa, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_5efd, 5); call(0x1008_a1e8, -0x3_bd1a);           /* call 0x1008a1e8 */
            ii(0x100c_5f02, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_5f05, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_5f09, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_5f0c, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x100c_5f0f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5f12, 5); call(0x1013_c0fa, 0x7_61e3);            /* call 0x1013c0fa */
            ii(0x100c_5f17, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_5f1c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_5f1f, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x100c_5f22, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5f25, 5); call(0x1013_c055, 0x7_612b);            /* call 0x1013c055 */
            ii(0x100c_5f2a, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_5f2d, 3); mov(edx, memd[ds, edx + 0x1]);          /* mov edx, [edx+0x1] */
            ii(0x100c_5f30, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_5f33, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5f36, 5); call(0x1013_c0fa, 0x7_61bf);            /* call 0x1013c0fa */
            ii(0x100c_5f3b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_5f3e, 3); mov(edx, memd[ds, edx + 0x3]);          /* mov edx, [edx+0x3] */
            ii(0x100c_5f41, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_5f44, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5f47, 5); call(0x1013_c0fa, 0x7_61ae);            /* call 0x1013c0fa */
            ii(0x100c_5f4c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_5f4f, 3); mov(edx, memd[ds, edx + 0x5]);          /* mov edx, [edx+0x5] */
            ii(0x100c_5f52, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_5f55, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5f58, 5); call(0x1013_c0fa, 0x7_619d);            /* call 0x1013c0fa */
            ii(0x100c_5f5d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_5f60, 3); mov(edx, memd[ds, edx + 0x79]);         /* mov edx, [edx+0x79] */
            ii(0x100c_5f63, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_5f66, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5f69, 5); call(0x1013_c0fa, 0x7_618c);            /* call 0x1013c0fa */
            ii(0x100c_5f6e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_5f71, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_5f74, 5); call(0x1007_6b90, -0x4_f3e9);           /* call 0x10076b90 */
            ii(0x100c_5f79, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_5f7c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5f7f, 5); call(0x1013_c0fa, 0x7_6176);            /* call 0x1013c0fa */
            ii(0x100c_5f84, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_5f87, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_5f8a, 5); call(0x100c_b000, 0x5071);              /* call 0x100cb000 */
            ii(0x100c_5f8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_5f91, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_5f94, 5); call(0x100c_af68, 0x4fcf);              /* call 0x100caf68 */
            ii(0x100c_5f99, 2); jmp(0x100c_5fa3, 0x8); goto l_0x100c_5fa3; /* jmp 0x100c5fa3 */
        l_0x100c_5f9b:
            ii(0x100c_5f9b, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_5f9e, 5); call(0x1007_6bf8, -0x4_f3ab);           /* call 0x10076bf8 */
        l_0x100c_5fa3:
            ii(0x100c_5fa3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_5fa5, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_5fa8, 5); call(0x1013_ad71, 0x7_4dc4);            /* call 0x1013ad71 */
            ii(0x100c_5fad, 2); test(al, al);                           /* test al, al */
            ii(0x100c_5faf, 2); if(jz(0x100c_5fc3, 0x12)) goto l_0x100c_5fc3; /* jz 0x100c5fc3 */
            ii(0x100c_5fb1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_5fb4, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_5fb7, 5); call(0x1008_a0f8, -0x3_bec4);           /* call 0x1008a0f8 */
            ii(0x100c_5fbc, 5); call(0x100b_8d8b, -0xd236);             /* call 0x100b8d8b */
            ii(0x100c_5fc1, 2); jmp(0x100c_5f9b, -0x28); goto l_0x100c_5f9b; /* jmp 0x100c5f9b */
        l_0x100c_5fc3:
            ii(0x100c_5fc3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_5fc6, 4); cmp(memd[ds, eax + 0x63], 0);           /* cmp dword [eax+0x63], 0x0 */
            ii(0x100c_5fca, 2); if(jz(0x100c_5fd5, 0x9)) goto l_0x100c_5fd5; /* jz 0x100c5fd5 */
            ii(0x100c_5fcc, 7); mov(memd[ss, ebp - 0x1c], 0x1);         /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100c_5fd3, 2); jmp(0x100c_5fdc, 0x7); goto l_0x100c_5fdc; /* jmp 0x100c5fdc */
        l_0x100c_5fd5:
            ii(0x100c_5fd5, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100c_5fdc:
            ii(0x100c_5fdc, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_5fdf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_5fe2, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_5fe6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5fe9, 5); call(0x1013_c0fa, 0x7_610c);            /* call 0x1013c0fa */
            ii(0x100c_5fee, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_5ff1, 4); cmp(memd[ds, eax + 0x63], 0);           /* cmp dword [eax+0x63], 0x0 */
            ii(0x100c_5ff5, 2); if(jz(0x100c_6038, 0x41)) goto l_0x100c_6038; /* jz 0x100c6038 */
            ii(0x100c_5ff7, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_5ffe, 2); jmp(0x100c_6006, 0x6); goto l_0x100c_6006; /* jmp 0x100c6006 */
        l_0x100c_6000:
            ii(0x100c_6000, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_6003, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100c_6006:
            ii(0x100c_6006, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_6009, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_6010, 2); if(jge(0x100c_6038, 0x26)) goto l_0x100c_6038; /* jge 0x100c6038 */
            ii(0x100c_6012, 6); mov(ebx, memd[ds, 0x101c_8172]);        /* mov ebx, [0x101c8172] */
            ii(0x100c_6018, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_601b, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_601f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_6022, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6024, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6027, 3); mov(eax, memd[ds, eax + 0x63]);         /* mov eax, [eax+0x63] */
            ii(0x100c_602a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_602c, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_602e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6031, 5); call(0x1013_c055, 0x7_601f);            /* call 0x1013c055 */
            ii(0x100c_6036, 2); jmp(0x100c_6000, -0x38); goto l_0x100c_6000; /* jmp 0x100c6000 */
        l_0x100c_6038:
            ii(0x100c_6038, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_603b, 4); cmp(memd[ds, eax + 0x67], 0);           /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_603f, 2); if(jz(0x100c_604a, 0x9)) goto l_0x100c_604a; /* jz 0x100c604a */
            ii(0x100c_6041, 7); mov(memd[ss, ebp - 0x20], 0x1);         /* mov dword [ebp-0x20], 0x1 */
            ii(0x100c_6048, 2); jmp(0x100c_6051, 0x7); goto l_0x100c_6051; /* jmp 0x100c6051 */
        l_0x100c_604a:
            ii(0x100c_604a, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x100c_6051:
            ii(0x100c_6051, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_6054, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_6057, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_605b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_605e, 5); call(0x1013_c0fa, 0x7_6097);            /* call 0x1013c0fa */
            ii(0x100c_6063, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6066, 4); cmp(memd[ds, eax + 0x67], 0);           /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_606a, 2); if(jz(0x100c_60ad, 0x41)) goto l_0x100c_60ad; /* jz 0x100c60ad */
            ii(0x100c_606c, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_6073, 2); jmp(0x100c_607b, 0x6); goto l_0x100c_607b; /* jmp 0x100c607b */
        l_0x100c_6075:
            ii(0x100c_6075, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_6078, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100c_607b:
            ii(0x100c_607b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_607e, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_6085, 2); if(jge(0x100c_60ad, 0x26)) goto l_0x100c_60ad; /* jge 0x100c60ad */
            ii(0x100c_6087, 6); mov(ebx, memd[ds, 0x101c_8172]);        /* mov ebx, [0x101c8172] */
            ii(0x100c_608d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_6090, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_6094, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_6097, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6099, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_609c, 3); mov(eax, memd[ds, eax + 0x67]);         /* mov eax, [eax+0x67] */
            ii(0x100c_609f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_60a1, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_60a3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_60a6, 5); call(0x1013_c055, 0x7_5faa);            /* call 0x1013c055 */
            ii(0x100c_60ab, 2); jmp(0x100c_6075, -0x38); goto l_0x100c_6075; /* jmp 0x100c6075 */
        l_0x100c_60ad:
            ii(0x100c_60ad, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100c_60b2, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_60b5, 3); add(edx, 0x77);                         /* add edx, 0x77 */
            ii(0x100c_60b8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_60bb, 5); call(0x1013_c055, 0x7_5f95);            /* call 0x1013c055 */
            ii(0x100c_60c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_60c2, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_60c5, 5); call(0x1008_8e4c, -0x3_d27e);           /* call 0x10088e4c */
            ii(0x100c_60ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_60cc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_60cd, 1); pop(edi);                               /* pop edi */
            ii(0x100c_60ce, 1); pop(esi);                               /* pop esi */
            ii(0x100c_60cf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_60d0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_60d1, 1); ret();                                  /* ret */
        }
    }
}
