using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_48ba-89334343")]
        public void Method_1015_48ba()
        {
            ii(0x1015_48ba, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1015_48bf, 5); calld(Definitions.sys_check_available_stack_size, 0x1_148e); /* call 0x10165d52 */
            ii(0x1015_48c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_48c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_48c6, 1); pushd(edx);                             /* push edx */
            ii(0x1015_48c7, 1); pushd(esi);                             /* push esi */
            ii(0x1015_48c8, 1); pushd(edi);                             /* push edi */
            ii(0x1015_48c9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_48ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_48cc, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_48d2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_48d5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_48d7, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_48dc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_48df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_48e2, 5); calld(0x1007_6074, -0xd_e873);          /* call 0x10076074 */
            ii(0x1015_48e7, 2); test(al, al);                           /* test al, al */
            ii(0x1015_48e9, 2); if(jnzd(0x1015_48f4, 0x9)) goto l_0x1015_48f4; /* jnz 0x101548f4 */
            ii(0x1015_48eb, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1015_48f2, 2); if(jzd(0x1015_48fa, 0x6)) goto l_0x1015_48fa; /* jz 0x101548fa */
        l_0x1015_48f4:
            ii(0x1015_48f4, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_48f8, 2); jmpd(0x1015_48fe, 0x4); goto l_0x1015_48fe; /* jmp 0x101548fe */
        l_0x1015_48fa:
            ii(0x1015_48fa, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1015_48fe:
            ii(0x1015_48fe, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_4901, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1015_4904, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1015_4908, 2); if(jzd(0x1015_4912, 0x8)) goto l_0x1015_4912; /* jz 0x10154912 */
            ii(0x1015_490a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_490d, 5); calld(0x1014_9fa8, -0xa96a);            /* call 0x10149fa8 */
        l_0x1015_4912:
            ii(0x1015_4912, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4915, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1015_4919, 3); shl(edx, 0x6);                          /* shl edx, 0x6 */
            ii(0x1015_491c, 3); add(edx, 0x20);                         /* add edx, 0x20 */
            ii(0x1015_491f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4922, 4); sub(dx, memw_a32[ds, eax + 0x16]);      /* sub dx, [eax+0x16] */
            ii(0x1015_4926, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1015_4929, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_492c, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1015_4930, 3); shl(edx, 0x6);                          /* shl edx, 0x6 */
            ii(0x1015_4933, 3); add(edx, 0x20);                         /* add edx, 0x20 */
            ii(0x1015_4936, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4939, 4); sub(dx, memw_a32[ds, eax + 0x18]);      /* sub dx, [eax+0x18] */
            ii(0x1015_493d, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1015_4940, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_4944, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1015_4948, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_494b, 5); calld(0x1014_9c2f, -0xad21);            /* call 0x10149c2f */
            ii(0x1015_4950, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4953, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1015_4957, 2); if(jzd(0x1015_4962, 0x9)) goto l_0x1015_4962; /* jz 0x10154962 */
            ii(0x1015_4959, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_495c, 4); test(memb_a32[ds, eax + 0x14], 0x1);    /* test byte [eax+0x14], 0x1 */
            ii(0x1015_4960, 2); if(jnzd(0x1015_4964, 0x2)) goto l_0x1015_4964; /* jnz 0x10154964 */
        l_0x1015_4962:
            ii(0x1015_4962, 2); jmpd(0x1015_4986, 0x22); goto l_0x1015_4986; /* jmp 0x10154986 */
        l_0x1015_4964:
            ii(0x1015_4964, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4967, 9); mov(memw_a32[ds, eax + 0xdb], 0xffc0);  /* mov word [eax+0xdb], 0xffc0 */
            ii(0x1015_4970, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4973, 7); mov(dx, memw_a32[ds, eax + 0xdb]);      /* mov dx, [eax+0xdb] */
            ii(0x1015_497a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_497d, 7); mov(memw_a32[ds, eax + 0xd9], dx);      /* mov [eax+0xd9], dx */
            ii(0x1015_4984, 2); jmpd(0x1015_49a6, 0x20); goto l_0x1015_49a6; /* jmp 0x101549a6 */
        l_0x1015_4986:
            ii(0x1015_4986, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4989, 9); mov(memw_a32[ds, eax + 0xdb], 0);       /* mov word [eax+0xdb], 0x0 */
            ii(0x1015_4992, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4995, 7); mov(dx, memw_a32[ds, eax + 0xdb]);      /* mov dx, [eax+0xdb] */
            ii(0x1015_499c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_499f, 7); mov(memw_a32[ds, eax + 0xd9], dx);      /* mov [eax+0xd9], dx */
        l_0x1015_49a6:
            ii(0x1015_49a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_49a9, 5); calld(0x1014_9cd1, -0xacdd);            /* call 0x10149cd1 */
            ii(0x1015_49ae, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1015_49b2, 2); if(jzd(0x1015_49bc, 0x8)) goto l_0x1015_49bc; /* jz 0x101549bc */
            ii(0x1015_49b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_49b7, 5); calld(0x1014_9fa8, -0xaa14);            /* call 0x10149fa8 */
        l_0x1015_49bc:
            ii(0x1015_49bc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_49be, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_49bf, 1); popd(edi);                              /* pop edi */
            ii(0x1015_49c0, 1); popd(esi);                              /* pop esi */
            ii(0x1015_49c1, 1); popd(edx);                              /* pop edx */
            ii(0x1015_49c2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_49c3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_49c4, 1); retd(); return;                         /* ret */
        }
    }
}
