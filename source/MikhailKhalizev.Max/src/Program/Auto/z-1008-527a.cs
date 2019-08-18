using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_527a-2d3b97bf")]
        public void Method_1008_527a()
        {
            ii(0x1008_527a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_527f, 5); calld(Definitions.sys_check_available_stack_size, 0xe_0ace); /* call 0x10165d52 */
            ii(0x1008_5284, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_5285, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_5286, 1); pushd(esi);                             /* push esi */
            ii(0x1008_5287, 1); pushd(edi);                             /* push edi */
            ii(0x1008_5288, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_5289, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_528b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_5291, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_5294, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_5297, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_529a, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_529d, 5); calld(0x1007_6574, -0xed2e);            /* call 0x10076574 */
            ii(0x1008_52a2, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1008_52a6, 2); if(jnzd(0x1008_52d7, 0x2f)) goto l_0x1008_52d7; /* jnz 0x100852d7 */
            ii(0x1008_52a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_52ab, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_52ae, 5); calld(0x1007_6574, -0xed3f);            /* call 0x10076574 */
            ii(0x1008_52b3, 3); mov(ebx, memd_a32[ds, eax + 0x1e]);     /* mov ebx, [eax+0x1e] */
            ii(0x1008_52b6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_52b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_52bc, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_52bf, 5); calld(0x1007_6574, -0xed50);            /* call 0x10076574 */
            ii(0x1008_52c4, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1008_52c7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_52ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_52cd, 5); calld(0x1007_6aac, -0xe826);            /* call 0x10076aac */
            ii(0x1008_52d2, 5); jmpd(0x1008_53db, 0x104); goto l_0x1008_53db; /* jmp 0x100853db */
        l_0x1008_52d7:
            ii(0x1008_52d7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_52da, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_52dd, 5); calld(0x1007_6574, -0xed6e);            /* call 0x10076574 */
            ii(0x1008_52e2, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1008_52e5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_52ea, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_52ec, 2); if(jzd(0x1008_5307, 0x19)) goto l_0x1008_5307; /* jz 0x10085307 */
            ii(0x1008_52ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_52f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_52f3, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_52f6, 5); calld(0x1007_6574, -0xed87);            /* call 0x10076574 */
            ii(0x1008_52fb, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1008_52fe, 5); calld(0x1013_ad71, 0xb_5a6e);           /* call 0x1013ad71 */
            ii(0x1008_5303, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5305, 2); if(jnzd(0x1008_5309, 0x2)) goto l_0x1008_5309; /* jnz 0x10085309 */
        l_0x1008_5307:
            ii(0x1008_5307, 2); jmpd(0x1008_5340, 0x37); goto l_0x1008_5340; /* jmp 0x10085340 */
        l_0x1008_5309:
            ii(0x1008_5309, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_530c, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_530f, 5); calld(0x1007_6574, -0xeda0);            /* call 0x10076574 */
            ii(0x1008_5314, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1008_5317, 5); calld(0x1007_69d8, -0xe944);            /* call 0x100769d8 */
            ii(0x1008_531c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_531f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_5322, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1008_5325, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5328, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_532b, 5); calld(0x1007_65d0, -0xed60);            /* call 0x100765d0 */
            ii(0x1008_5330, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_5332, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_5335, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_5338, 3); calld_abs(memd_a32[ds, ecx + 0x18]);    /* call dword [ecx+0x18] */
            ii(0x1008_533b, 5); jmpd(0x1008_53db, 0x9b); goto l_0x1008_53db; /* jmp 0x100853db */
        l_0x1008_5340:
            ii(0x1008_5340, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5343, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5346, 5); calld(0x1007_6574, -0xedd7);            /* call 0x10076574 */
            ii(0x1008_534b, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1008_534e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_5353, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_5355, 2); if(jzd(0x1008_5383, 0x2c)) goto l_0x1008_5383; /* jz 0x10085383 */
            ii(0x1008_5357, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_535a, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_535d, 5); calld(0x1007_6574, -0xedee);            /* call 0x10076574 */
            ii(0x1008_5362, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1008_5365, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_5368, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_536a, 2); if(jnzd(0x1008_5381, 0x15)) goto l_0x1008_5381; /* jnz 0x10085381 */
            ii(0x1008_536c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_536f, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5372, 5); calld(0x1007_6574, -0xee03);            /* call 0x10076574 */
            ii(0x1008_5377, 3); mov(eax, memd_a32[ds, eax + 0x1e]);     /* mov eax, [eax+0x1e] */
            ii(0x1008_537a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_537d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_537f, 2); if(jzd(0x1008_5383, 0x2)) goto l_0x1008_5383; /* jz 0x10085383 */
        l_0x1008_5381:
            ii(0x1008_5381, 2); jmpd(0x1008_5385, 0x2); goto l_0x1008_5385; /* jmp 0x10085385 */
        l_0x1008_5383:
            ii(0x1008_5383, 2); jmpd(0x1008_53b1, 0x2c); goto l_0x1008_53b1; /* jmp 0x100853b1 */
        l_0x1008_5385:
            ii(0x1008_5385, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5388, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_538b, 5); calld(0x1007_6574, -0xee1c);            /* call 0x10076574 */
            ii(0x1008_5390, 3); mov(ebx, memd_a32[ds, eax + 0x1e]);     /* mov ebx, [eax+0x1e] */
            ii(0x1008_5393, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_5396, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5399, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_539c, 5); calld(0x1007_6574, -0xee2d);            /* call 0x10076574 */
            ii(0x1008_53a1, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1008_53a4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_53a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_53aa, 5); calld(0x1007_6aac, -0xe903);            /* call 0x10076aac */
            ii(0x1008_53af, 2); jmpd(0x1008_53db, 0x2a); goto l_0x1008_53db; /* jmp 0x100853db */
        l_0x1008_53b1:
            ii(0x1008_53b1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_53b4, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_53b7, 5); calld(0x1007_6574, -0xee48);            /* call 0x10076574 */
            ii(0x1008_53bc, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1008_53bf, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_53c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_53c5, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_53c8, 5); calld(0x1007_6574, -0xee59);            /* call 0x10076574 */
            ii(0x1008_53cd, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1008_53d0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_53d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_53d6, 5); calld(0x1007_6aac, -0xe92f);            /* call 0x10076aac */
        l_0x1008_53db:
            ii(0x1008_53db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_53de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_53e0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_53e1, 1); popd(edi);                              /* pop edi */
            ii(0x1008_53e2, 1); popd(esi);                              /* pop esi */
            ii(0x1008_53e3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_53e4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_53e5, 1); retd(); return;                         /* ret */
        }
    }
}
