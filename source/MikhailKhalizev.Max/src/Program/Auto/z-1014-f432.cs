using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f432-f0245437")]
        public void Method_1014_f432()
        {
            ii(0x1014_f432, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_f437, 5); calld(Definitions.sys_check_available_stack_size, 0x1_6916); /* call 0x10165d52 */
            ii(0x1014_f43c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_f43d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_f43e, 1); pushd(esi);                             /* push esi */
            ii(0x1014_f43f, 1); pushd(edi);                             /* push edi */
            ii(0x1014_f440, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_f441, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_f443, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_f449, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_f44c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_f44f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f453, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1014_f456, 7); cmp(memb_a32[ds, eax + 0xb0], 0);       /* cmp byte [eax+0xb0], 0x0 */
            ii(0x1014_f45d, 2); if(jnzd(0x1014_f48f, 0x30)) goto l_0x1014_f48f; /* jnz 0x1014f48f */
            ii(0x1014_f45f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f462, 5); calld(0x1016_433b, 0x1_4ed4);           /* call 0x1016433b */
            ii(0x1014_f467, 2); test(al, al);                           /* test al, al */
            ii(0x1014_f469, 2); if(jnzd(0x1014_f475, 0xa)) goto l_0x1014_f475; /* jnz 0x1014f475 */
            ii(0x1014_f46b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f46e, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_f473, 2); if(jnzd(0x1014_f477, 0x2)) goto l_0x1014_f477; /* jnz 0x1014f477 */
        l_0x1014_f475:
            ii(0x1014_f475, 2); jmpd(0x1014_f481, 0xa); goto l_0x1014_f481; /* jmp 0x1014f481 */
        l_0x1014_f477:
            ii(0x1014_f477, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f47a, 5); cmp(memw_a32[ds, eax + 0x8], 0x29);     /* cmp word [eax+0x8], 0x29 */
            ii(0x1014_f47f, 2); if(jnzd(0x1014_f483, 0x2)) goto l_0x1014_f483; /* jnz 0x1014f483 */
        l_0x1014_f481:
            ii(0x1014_f481, 2); jmpd(0x1014_f48d, 0xa); goto l_0x1014_f48d; /* jmp 0x1014f48d */
        l_0x1014_f483:
            ii(0x1014_f483, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f486, 5); cmp(memw_a32[ds, eax + 0x8], 0x2a);     /* cmp word [eax+0x8], 0x2a */
            ii(0x1014_f48b, 2); if(jnzd(0x1014_f48f, 0x2)) goto l_0x1014_f48f; /* jnz 0x1014f48f */
        l_0x1014_f48d:
            ii(0x1014_f48d, 2); jmpd(0x1014_f4a0, 0x11); goto l_0x1014_f4a0; /* jmp 0x1014f4a0 */
        l_0x1014_f48f:
            ii(0x1014_f48f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f493, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f496, 5); calld(0x1014_f634, 0x199);              /* call 0x1014f634 */
            ii(0x1014_f49b, 5); jmpd(0x1014_f53c, 0x9c); goto l_0x1014_f53c; /* jmp 0x1014f53c */
        l_0x1014_f4a0:
            ii(0x1014_f4a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f4a3, 5); calld(0x1016_433b, 0x1_4e93);           /* call 0x1016433b */
            ii(0x1014_f4a8, 2); test(al, al);                           /* test al, al */
            ii(0x1014_f4aa, 2); if(jzd(0x1014_f4e8, 0x3c)) goto l_0x1014_f4e8; /* jz 0x1014f4e8 */
            ii(0x1014_f4ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f4af, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1014_f4b2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_f4b5, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1014_f4ba, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_f4bd, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_f4c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f4c3, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1014_f4c6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_f4c9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_f4cb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f4cf, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_f4d5, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a7]); /* mov eax, [eax+0x101ca6a7] */
            ii(0x1014_f4db, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_f4dd, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_f4df, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_f4e4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_f4e6, 2); if(jzd(0x1014_f530, 0x48)) goto l_0x1014_f530; /* jz 0x1014f530 */
        l_0x1014_f4e8:
            ii(0x1014_f4e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f4eb, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_f4f0, 2); if(jnzd(0x1014_f52e, 0x3c)) goto l_0x1014_f52e; /* jnz 0x1014f52e */
            ii(0x1014_f4f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f4f5, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1014_f4f8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_f4fb, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1014_f500, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_f503, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_f506, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f509, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1014_f50c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_f50f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_f511, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f515, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_f51b, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6ab]); /* mov eax, [eax+0x101ca6ab] */
            ii(0x1014_f521, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_f523, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_f525, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_f52a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_f52c, 2); if(jzd(0x1014_f530, 0x2)) goto l_0x1014_f530; /* jz 0x1014f530 */
        l_0x1014_f52e:
            ii(0x1014_f52e, 2); jmpd(0x1014_f53c, 0xc); goto l_0x1014_f53c; /* jmp 0x1014f53c */
        l_0x1014_f530:
            ii(0x1014_f530, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f534, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f537, 5); calld(0x1014_f2a2, -0x29a);             /* call 0x1014f2a2 */
        l_0x1014_f53c:
            ii(0x1014_f53c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f53e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_f53f, 1); popd(edi);                              /* pop edi */
            ii(0x1014_f540, 1); popd(esi);                              /* pop esi */
            ii(0x1014_f541, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_f542, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_f543, 1); retd(); return;                         /* ret */
        }
    }
}
