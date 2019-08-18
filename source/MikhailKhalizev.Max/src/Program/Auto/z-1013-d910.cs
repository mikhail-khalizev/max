using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("67c24f95-74bd-445c-b791-8276cb4e16fa")]
        public void Method_1013_d910()
        {
            ii(0x1013_d910, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_d915, 5); calld(Definitions.sys_check_available_stack_size, 0x2_8438); /* call 0x10165d52 */
            ii(0x1013_d91a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_d91b, 1); pushd(esi);                             /* push esi */
            ii(0x1013_d91c, 1); pushd(edi);                             /* push edi */
            ii(0x1013_d91d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_d91e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d920, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_d926, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_d929, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_d92c, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1013_d92f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d932, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1013_d936, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1013_d93a, 2); if(jld(0x1013_d949, 0xd)) goto l_0x1013_d949; /* jl 0x1013d949 */
            ii(0x1013_d93c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d93f, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1013_d943, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1013_d947, 2); if(jled(0x1013_d94b, 0x2)) goto l_0x1013_d94b; /* jle 0x1013d94b */
        l_0x1013_d949:
            ii(0x1013_d949, 2); jmpd(0x1013_d977, 0x2c); goto l_0x1013_d977; /* jmp 0x1013d977 */
        l_0x1013_d94b:
            ii(0x1013_d94b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d94e, 4); cmp(memd_a32[ds, eax + 0x4], 0);        /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_d952, 2); if(jzd(0x1013_d977, 0x23)) goto l_0x1013_d977; /* jz 0x1013d977 */
            ii(0x1013_d954, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d957, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1013_d95a, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1013_d95c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d95f, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1013_d962, 5); calld(/* sys */ 0x1018_0dff, 0x4_3498); /* call 0x10180dff */
            ii(0x1013_d967, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_d969, 2); if(jnzd(0x1013_d977, 0xc)) goto l_0x1013_d977; /* jnz 0x1013d977 */
            ii(0x1013_d96b, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1013_d972, 5); jmpd(0x1013_d9e1, 0x6a); goto l_0x1013_d9e1; /* jmp 0x1013d9e1 */
        l_0x1013_d977:
            ii(0x1013_d977, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_d97e, 2); jmpd(0x1013_d986, 0x6); goto l_0x1013_d986; /* jmp 0x1013d986 */
        l_0x1013_d980:
            ii(0x1013_d980, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_d983, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1013_d986:
            ii(0x1013_d986, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_d988, 5); mov(al, memb_a32[ds, 0x101c_7298]);     /* mov al, [0x101c7298] */
            ii(0x1013_d98d, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1013_d991, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_d993, 2); if(jged(0x1013_d9da, 0x45)) goto l_0x1013_d9da; /* jge 0x1013d9da */
            ii(0x1013_d995, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1013_d999, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_d99c, 5); mov(edx, 0x101c_7299);                  /* mov edx, 0x101c7299 */
            ii(0x1013_d9a1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_d9a3, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1013_d9a6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_d9a9, 4); cmp(memb_a32[ds, eax + 0xa], 0x3);      /* cmp byte [eax+0xa], 0x3 */
            ii(0x1013_d9ad, 2); if(jnzd(0x1013_d9bd, 0xe)) goto l_0x1013_d9bd; /* jnz 0x1013d9bd */
            ii(0x1013_d9af, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_d9b2, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1013_d9b5, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_d9b9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_d9bb, 2); if(jged(0x1013_d9bf, 0x2)) goto l_0x1013_d9bf; /* jge 0x1013d9bf */
        l_0x1013_d9bd:
            ii(0x1013_d9bd, 2); jmpd(0x1013_d9cd, 0xe); goto l_0x1013_d9cd; /* jmp 0x1013d9cd */
        l_0x1013_d9bf:
            ii(0x1013_d9bf, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_d9c2, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1013_d9c5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_d9c9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_d9cb, 2); if(jled(0x1013_d9cf, 0x2)) goto l_0x1013_d9cf; /* jle 0x1013d9cf */
        l_0x1013_d9cd:
            ii(0x1013_d9cd, 2); jmpd(0x1013_d9d8, 0x9); goto l_0x1013_d9d8; /* jmp 0x1013d9d8 */
        l_0x1013_d9cf:
            ii(0x1013_d9cf, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1013_d9d6, 2); jmpd(0x1013_d9e1, 0x9); goto l_0x1013_d9e1; /* jmp 0x1013d9e1 */
        l_0x1013_d9d8:
            ii(0x1013_d9d8, 2); jmpd(0x1013_d980, -0x5a); goto l_0x1013_d980; /* jmp 0x1013d980 */
        l_0x1013_d9da:
            ii(0x1013_d9da, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1013_d9e1:
            ii(0x1013_d9e1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_d9e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d9e6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_d9e7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_d9e8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_d9e9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_d9ea, 1); retd(); return;                         /* ret */
        }
    }
}
