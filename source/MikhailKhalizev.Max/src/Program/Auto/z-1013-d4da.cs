using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2966abe3-65ea-42fb-8977-be45abe09d15")]
        public void Method_1013_d4da()
        {
            ii(0x1013_d4da, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1013_d4df, 5); calld(Definitions.sys_check_available_stack_size, 0x2_886e); /* call 0x10165d52 */
            ii(0x1013_d4e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_d4e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_d4e6, 1); pushd(esi);                             /* push esi */
            ii(0x1013_d4e7, 1); pushd(edi);                             /* push edi */
            ii(0x1013_d4e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_d4e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d4eb, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_d4f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_d4f4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_d4f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d4fa, 7); cmp(memd_a32[ds, eax + 0xda5], 0);      /* cmp dword [eax+0xda5], 0x0 */
            ii(0x1013_d501, 2); if(jzd(0x1013_d519, 0x16)) goto l_0x1013_d519; /* jz 0x1013d519 */
            ii(0x1013_d503, 5); calld(0x1014_82f4, 0xadec);             /* call 0x101482f4 */
            ii(0x1013_d508, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_d50a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d50d, 6); mov(eax, memd_a32[ds, eax + 0xda5]);    /* mov eax, [eax+0xda5] */
            ii(0x1013_d513, 6); mov(memd_a32[ds, eax + 0x8b], edx);     /* mov [eax+0x8b], edx */
        l_0x1013_d519:
            ii(0x1013_d519, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d51c, 10); mov(memd_a32[ds, eax + 0xda5], 0);     /* mov dword [eax+0xda5], 0x0 */
            ii(0x1013_d526, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d529, 4); mov(memb_a32[ds, eax + 0x2c], 0);       /* mov byte [eax+0x2c], 0x0 */
            ii(0x1013_d52d, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_d534, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d537, 5); calld(0x1007_6154, -0xc_73e8);          /* call 0x10076154 */
            ii(0x1013_d53c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_d53f, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_d546, 2); jmpd(0x1013_d54e, 0x6); goto l_0x1013_d54e; /* jmp 0x1013d54e */
        l_0x1013_d548:
            ii(0x1013_d548, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d54b, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1013_d54e:
            ii(0x1013_d54e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_d550, 5); mov(al, memb_a32[ds, 0x101c_7298]);     /* mov al, [0x101c7298] */
            ii(0x1013_d555, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_d559, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_d55b, 2); if(jged(0x1013_d5b0, 0x53)) goto l_0x1013_d5b0; /* jge 0x1013d5b0 */
            ii(0x1013_d55d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_d561, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_d564, 5); mov(edx, 0x101c_7299);                  /* mov edx, 0x101c7299 */
            ii(0x1013_d569, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_d56b, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1013_d56e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_d571, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1013_d575, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1013_d579, 2); if(jnzd(0x1013_d584, 0x9)) goto l_0x1013_d584; /* jnz 0x1013d584 */
            ii(0x1013_d57b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_d57e, 4); cmp(memb_a32[ds, eax + 0xa], 0);        /* cmp byte [eax+0xa], 0x0 */
            ii(0x1013_d582, 2); if(jnzd(0x1013_d5ae, 0x2a)) goto l_0x1013_d5ae; /* jnz 0x1013d5ae */
        l_0x1013_d584:
            ii(0x1013_d584, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_d587, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1013_d58b, 2); if(jzd(0x1013_d5a8, 0x1b)) goto l_0x1013_d5a8; /* jz 0x1013d5a8 */
            ii(0x1013_d58d, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1013_d592, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1013_d595, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1013_d599, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_d59c, 5); mov(ecx, 0x101c_7299);                  /* mov ecx, 0x101c7299 */
            ii(0x1013_d5a1, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_d5a3, 5); calld(Definitions.sys_memcpy, 0x2_88a3); /* call 0x10165e4b */
        l_0x1013_d5a8:
            ii(0x1013_d5a8, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_d5ab, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1013_d5ae:
            ii(0x1013_d5ae, 2); jmpd(0x1013_d548, -0x68); goto l_0x1013_d548; /* jmp 0x1013d548 */
        l_0x1013_d5b0:
            ii(0x1013_d5b0, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1013_d5b3, 5); mov(memb_a32[ds, 0x101c_7298], al);     /* mov [0x101c7298], al */
            ii(0x1013_d5b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d5ba, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_d5bb, 1); popd(edi);                              /* pop edi */
            ii(0x1013_d5bc, 1); popd(esi);                              /* pop esi */
            ii(0x1013_d5bd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_d5be, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_d5bf, 1); retd(); return;                         /* ret */
        }
    }
}
