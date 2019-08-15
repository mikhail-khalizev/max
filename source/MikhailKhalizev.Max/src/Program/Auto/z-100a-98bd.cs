using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("89f263de-3ae0-43c4-a631-a810b990d3b3")]
        public void Method_100a_98bd()
        {
            ii(0x100a_98bd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_98c2, 5); calld(Definitions.sys_check_available_stack_size, 0xb_c48b); /* call 0x10165d52 */
            ii(0x100a_98c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_98c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_98c9, 1); pushd(edx);                             /* push edx */
            ii(0x100a_98ca, 1); pushd(esi);                             /* push esi */
            ii(0x100a_98cb, 1); pushd(edi);                             /* push edi */
            ii(0x100a_98cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_98cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_98cf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_98d5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_98d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_98db, 6); mov(memw_a32[ds, eax + 0xa], 0);        /* mov word [eax+0xa], 0x0 */
            ii(0x100a_98e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_98e4, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x100a_98e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_98eb, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x100a_98ef, 4); neg(memw_a32[ds, eax + 0xc]);           /* neg word [eax+0xc] */
            ii(0x100a_98f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_98f6, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_98f9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_98fc, 3); mov(memd_a32[ds, edx + 0x12], eax);     /* mov [edx+0x12], eax */
            ii(0x100a_98ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9902, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x100a_9905, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_9908, 3); mov(memd_a32[ds, edx + 0x16], eax);     /* mov [edx+0x16], eax */
            ii(0x100a_990b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_990e, 6); mov(memw_a32[ds, eax + 0x1a], 0x1);     /* mov word [eax+0x1a], 0x1 */
            ii(0x100a_9914, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9917, 6); mov(memw_a32[ds, eax + 0x1c], 0x1);     /* mov word [eax+0x1c], 0x1 */
            ii(0x100a_991d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9920, 6); mov(memw_a32[ds, eax + 0x4], 0);        /* mov word [eax+0x4], 0x0 */
            ii(0x100a_9926, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9929, 4); mov(ax, memw_a32[ds, eax + 0xa]);       /* mov ax, [eax+0xa] */
            ii(0x100a_992d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_9930, 3); add(ax, memw_a32[ds, edx]);             /* add ax, [edx] */
            ii(0x100a_9933, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_9936, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
            ii(0x100a_993a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_993d, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100a_9941, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_9944, 4); add(ax, memw_a32[ds, edx + 0x2]);       /* add ax, [edx+0x2] */
            ii(0x100a_9948, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_994b, 4); mov(memw_a32[ds, edx + 0x10], ax);      /* mov [edx+0x10], ax */
            ii(0x100a_994f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9952, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100a_9955, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_9958, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_995a, 2); if(jld(0x100a_996c, 0x10)) goto l_0x100a_996c; /* jl 0x100a996c */
            ii(0x100a_995c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_995f, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x100a_9963, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100a_996a, 2); if(jld(0x100a_996e, 0x2)) goto l_0x100a_996e; /* jl 0x100a996e */
        l_0x100a_996c:
            ii(0x100a_996c, 2); jmpd(0x100a_997b, 0xd); goto l_0x100a_997b; /* jmp 0x100a997b */
        l_0x100a_996e:
            ii(0x100a_996e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9971, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100a_9974, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_9977, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_9979, 2); if(jged(0x100a_997d, 0x2)) goto l_0x100a_997d; /* jge 0x100a997d */
        l_0x100a_997b:
            ii(0x100a_997b, 2); jmpd(0x100a_998d, 0x10); goto l_0x100a_998d; /* jmp 0x100a998d */
        l_0x100a_997d:
            ii(0x100a_997d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9980, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x100a_9984, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100a_998b, 2); if(jld(0x100a_999a, 0xd)) goto l_0x100a_999a; /* jl 0x100a999a */
        l_0x100a_998d:
            ii(0x100a_998d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9990, 5); calld(0x100a_9ae0, 0x14b);              /* call 0x100a9ae0 */
            ii(0x100a_9995, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100a_9998, 2); jmpd(0x100a_999e, 0x4); goto l_0x100a_999e; /* jmp 0x100a999e */
        l_0x100a_999a:
            ii(0x100a_999a, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100a_999e:
            ii(0x100a_999e, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_99a1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_99a3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_99a4, 1); popd(edi);                              /* pop edi */
            ii(0x100a_99a5, 1); popd(esi);                              /* pop esi */
            ii(0x100a_99a6, 1); popd(edx);                              /* pop edx */
            ii(0x100a_99a7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_99a8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_99a9, 1); retd(); return;                         /* ret */
        }
    }
}
