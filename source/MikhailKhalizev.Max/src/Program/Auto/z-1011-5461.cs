using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5461-ff20da05")]
        public void Method_1011_5461()
        {
            ii(0x1011_5461, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_5466, 5); calld(Definitions.sys_check_available_stack_size, 0x5_08e7); /* call 0x10165d52 */
            ii(0x1011_546b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_546c, 1); pushd(esi);                             /* push esi */
            ii(0x1011_546d, 1); pushd(edi);                             /* push edi */
            ii(0x1011_546e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_546f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5471, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_5477, 5); calld(/* sys */ 0x1016_b208, 0x5_5d8c); /* call 0x1016b208 */
            ii(0x1011_547c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_547f, 5); cmp(memw_a32[ss, ebp - 0x4], 0);        /* cmp word [ebp-0x4], 0x0 */
            ii(0x1011_5484, 6); if(jzd(0x1011_5542, 0xb8)) goto l_0x1011_5542; /* jz 0x10115542 */
            ii(0x1011_548a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_548d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_5490, 5); jmpd(0x1011_5514, 0x7f); goto l_0x1011_5514; /* jmp 0x10115514 */
        l_0x1011_5495:
            ii(0x1011_5495, 7); cmp(memd_a32[ds, 0x101b_af78], 0);      /* cmp dword [0x101baf78], 0x0 */
            ii(0x1011_549c, 6); if(jzd(0x1011_5542, 0xa0)) goto l_0x1011_5542; /* jz 0x10115542 */
            ii(0x1011_54a2, 7); cmp(memd_a32[ds, 0x101c_4e58], 0x1);    /* cmp dword [0x101c4e58], 0x1 */
            ii(0x1011_54a9, 2); if(jnzd(0x1011_54bd, 0x12)) goto l_0x1011_54bd; /* jnz 0x101154bd */
            ii(0x1011_54ab, 6); inc(memd_a32[ds, 0x101c_4e5c]);         /* inc dword [0x101c4e5c] */
            ii(0x1011_54b1, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1011_54b8, 5); jmpd(0x1011_5561, 0xa4); goto l_0x1011_5561; /* jmp 0x10115561 */
        l_0x1011_54bd:
            ii(0x1011_54bd, 10); mov(memd_a32[ds, 0x101c_4e58], 0x1);   /* mov dword [0x101c4e58], 0x1 */
            ii(0x1011_54c7, 5); jmpd(0x1011_5542, 0x76); goto l_0x1011_5542; /* jmp 0x10115542 */
        l_0x1011_54cc:
            ii(0x1011_54cc, 7); cmp(memd_a32[ds, 0x101c_4e58], 0x1);    /* cmp dword [0x101c4e58], 0x1 */
            ii(0x1011_54d3, 2); if(jnzd(0x1011_54e1, 0xc)) goto l_0x1011_54e1; /* jnz 0x101154e1 */
            ii(0x1011_54d5, 10); mov(memd_a32[ds, 0x101c_4e58], 0);     /* mov dword [0x101c4e58], 0x0 */
            ii(0x1011_54df, 2); jmpd(0x1011_54ed, 0xc); goto l_0x1011_54ed; /* jmp 0x101154ed */
        l_0x1011_54e1:
            ii(0x1011_54e1, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x1011_54e8, 5); jmpd(0x1011_5561, 0x74); goto l_0x1011_5561; /* jmp 0x10115561 */
        l_0x1011_54ed:
            ii(0x1011_54ed, 2); jmpd(0x1011_5542, 0x53); goto l_0x1011_5542; /* jmp 0x10115542 */
        l_0x1011_54ef:
            ii(0x1011_54ef, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_54f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_54f5, 2); if(jgd(0x1011_5500, 0x9)) goto l_0x1011_5500; /* jg 0x10115500 */
            ii(0x1011_54f7, 5); calld(/* sys */ 0x1016_c348, 0x5_6e4c); /* call 0x1016c348 */
            ii(0x1011_54fc, 2); test(al, 0x3);                          /* test al, 0x3 */
            ii(0x1011_54fe, 2); if(jzd(0x1011_5512, 0x12)) goto l_0x1011_5512; /* jz 0x10115512 */
        l_0x1011_5500:
            ii(0x1011_5500, 7); cmp(memd_a32[ds, 0x101b_af74], 0);      /* cmp dword [0x101baf74], 0x0 */
            ii(0x1011_5507, 2); if(jzd(0x1011_5512, 0x9)) goto l_0x1011_5512; /* jz 0x10115512 */
            ii(0x1011_5509, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x1011_5510, 2); jmpd(0x1011_5561, 0x4f); goto l_0x1011_5561; /* jmp 0x10115561 */
        l_0x1011_5512:
            ii(0x1011_5512, 2); jmpd(0x1011_5542, 0x2e); goto l_0x1011_5542; /* jmp 0x10115542 */
        l_0x1011_5514:
            ii(0x1011_5514, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_5517, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_551a, 5); cmp(memw_a32[ss, ebp - 0x10], 0x53);    /* cmp word [ebp-0x10], 0x53 */
            ii(0x1011_551f, 2); if(jbd(0x1011_5539, 0x18)) goto l_0x1011_5539; /* jb 0x10115539 */
            ii(0x1011_5521, 5); cmp(memw_a32[ss, ebp - 0x10], 0x53);    /* cmp word [ebp-0x10], 0x53 */
            ii(0x1011_5526, 6); if(jbed(0x1011_5495, -0x97)) goto l_0x1011_5495; /* jbe 0x10115495 */
            ii(0x1011_552c, 5); cmp(memw_a32[ss, ebp - 0x10], 0x73);    /* cmp word [ebp-0x10], 0x73 */
            ii(0x1011_5531, 6); if(jzd(0x1011_5495, -0xa2)) goto l_0x1011_5495; /* jz 0x10115495 */
            ii(0x1011_5537, 2); jmpd(0x1011_54ef, -0x4a); goto l_0x1011_54ef; /* jmp 0x101154ef */
        l_0x1011_5539:
            ii(0x1011_5539, 5); cmp(memw_a32[ss, ebp - 0x10], 0xd);     /* cmp word [ebp-0x10], 0xd */
            ii(0x1011_553e, 2); if(jzd(0x1011_54cc, -0x74)) goto l_0x1011_54cc; /* jz 0x101154cc */
            ii(0x1011_5540, 2); jmpd(0x1011_54ef, -0x53); goto l_0x1011_54ef; /* jmp 0x101154ef */
        l_0x1011_5542:
            ii(0x1011_5542, 7); cmp(memd_a32[ds, 0x101c_4e58], 0x1);    /* cmp dword [0x101c4e58], 0x1 */
            ii(0x1011_5549, 2); if(jnzd(0x1011_5554, 0x9)) goto l_0x1011_5554; /* jnz 0x10115554 */
            ii(0x1011_554b, 7); mov(memd_a32[ss, ebp - 0x8], 0xffff_ffff); /* mov dword [ebp-0x8], 0xffffffff */
            ii(0x1011_5552, 2); jmpd(0x1011_5561, 0xd); goto l_0x1011_5561; /* jmp 0x10115561 */
        l_0x1011_5554:
            ii(0x1011_5554, 6); inc(memd_a32[ds, 0x101c_4e5c]);         /* inc dword [0x101c4e5c] */
            ii(0x1011_555a, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1011_5561:
            ii(0x1011_5561, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_5564, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_5566, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5567, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5568, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5569, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_556a, 1); retd(); return;                         /* ret */
        }
    }
}
