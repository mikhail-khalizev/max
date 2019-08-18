using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c1bd-526a0e73")]
        public void Method_100e_c1bd()
        {
            ii(0x100e_c1bd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_c1c2, 5); calld(Definitions.sys_check_available_stack_size, 0x7_9b8b); /* call 0x10165d52 */
            ii(0x100e_c1c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_c1c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_c1c9, 1); pushd(edx);                             /* push edx */
            ii(0x100e_c1ca, 1); pushd(esi);                             /* push esi */
            ii(0x100e_c1cb, 1); pushd(edi);                             /* push edi */
            ii(0x100e_c1cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_c1cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_c1cf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_c1d5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_c1d8, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100e_c1dd, 5); calld(0x1007_5fdc, -0x7_6206);          /* call 0x10075fdc */
            ii(0x100e_c1e2, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_c1e5, 2); if(jnzd(0x100e_c1f4, 0xd)) goto l_0x100e_c1f4; /* jnz 0x100ec1f4 */
            ii(0x100e_c1e7, 5); mov(eax, memd_a32[ds, 0x101c_3980]);    /* mov eax, [0x101c3980] */
            ii(0x100e_c1ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_c1ef, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_c1f2, 2); if(jzd(0x100e_c1f6, 0x2)) goto l_0x100e_c1f6; /* jz 0x100ec1f6 */
        l_0x100e_c1f4:
            ii(0x100e_c1f4, 2); jmpd(0x100e_c1fe, 0x8); goto l_0x100e_c1fe; /* jmp 0x100ec1fe */
        l_0x100e_c1f6:
            ii(0x100e_c1f6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c1fa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_c1fc, 2); if(jzd(0x100e_c200, 0x2)) goto l_0x100e_c200; /* jz 0x100ec200 */
        l_0x100e_c1fe:
            ii(0x100e_c1fe, 2); jmpd(0x100e_c206, 0x6); goto l_0x100e_c206; /* jmp 0x100ec206 */
        l_0x100e_c200:
            ii(0x100e_c200, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100e_c204, 2); jmpd(0x100e_c263, 0x5d); goto l_0x100e_c263; /* jmp 0x100ec263 */
        l_0x100e_c206:
            ii(0x100e_c206, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x100e_c20b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c20f, 5); calld(0x100e_bb28, -0x6ec);             /* call 0x100ebb28 */
            ii(0x100e_c214, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c216, 2); if(jnzd(0x100e_c22a, 0x12)) goto l_0x100e_c22a; /* jnz 0x100ec22a */
            ii(0x100e_c218, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x100e_c21d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c221, 5); calld(0x100e_bb28, -0x6fe);             /* call 0x100ebb28 */
            ii(0x100e_c226, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c228, 2); if(jzd(0x100e_c22c, 0x2)) goto l_0x100e_c22c; /* jz 0x100ec22c */
        l_0x100e_c22a:
            ii(0x100e_c22a, 2); jmpd(0x100e_c23e, 0x12); goto l_0x100e_c23e; /* jmp 0x100ec23e */
        l_0x100e_c22c:
            ii(0x100e_c22c, 5); mov(edx, 0x101c_819c);                  /* mov edx, 0x101c819c */
            ii(0x100e_c231, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c235, 5); calld(0x100e_bb28, -0x712);             /* call 0x100ebb28 */
            ii(0x100e_c23a, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c23c, 2); if(jzd(0x100e_c244, 0x6)) goto l_0x100e_c244; /* jz 0x100ec244 */
        l_0x100e_c23e:
            ii(0x100e_c23e, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100e_c242, 2); jmpd(0x100e_c263, 0x1f); goto l_0x100e_c263; /* jmp 0x100ec263 */
        l_0x100e_c244:
            ii(0x100e_c244, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c248, 5); calld(0x100e_bd26, -0x527);             /* call 0x100ebd26 */
            ii(0x100e_c24d, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c24f, 2); if(jzd(0x100e_c257, 0x6)) goto l_0x100e_c257; /* jz 0x100ec257 */
            ii(0x100e_c251, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100e_c255, 2); jmpd(0x100e_c263, 0xc); goto l_0x100e_c263; /* jmp 0x100ec263 */
        l_0x100e_c257:
            ii(0x100e_c257, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c25b, 5); calld(0x100e_bf7b, -0x2e5);             /* call 0x100ebf7b */
            ii(0x100e_c260, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x100e_c263:
            ii(0x100e_c263, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_c266, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c268, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_c269, 1); popd(edi);                              /* pop edi */
            ii(0x100e_c26a, 1); popd(esi);                              /* pop esi */
            ii(0x100e_c26b, 1); popd(edx);                              /* pop edx */
            ii(0x100e_c26c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_c26d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_c26e, 1); retd(); return;                         /* ret */
        }
    }
}
