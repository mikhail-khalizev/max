using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77ead843-c398-4db5-bbb9-b572b2b3211e")]
        public void /* sys */ Method_1016_8e14()
        {
            ii(0x1016_8e14, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_8e15, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_8e16, 1); pushd(esi);                             /* push esi */
            ii(0x1016_8e17, 1); pushd(edi);                             /* push edi */
            ii(0x1016_8e18, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_8e19, 3); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1016_8e1c, 4); mov(memd_a32[ss, esp + 0x20], eax);     /* mov [esp+0x20], eax */
            ii(0x1016_8e20, 4); mov(memd_a32[ss, esp + 0x1c], edx);     /* mov [esp+0x1c], edx */
            ii(0x1016_8e24, 3); mov(ebp, memd_a32[ds, eax + 0x34]);     /* mov ebp, [eax+0x34] */
            ii(0x1016_8e27, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x1016_8e2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_8e2c, 4); mov(memd_a32[ss, esp + 0x10], eax);     /* mov [esp+0x10], eax */
            ii(0x1016_8e30, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8e34, 4); mov(memd_a32[ss, esp + 0x14], edx);     /* mov [esp+0x14], edx */
            ii(0x1016_8e38, 4); test(memb_a32[ds, eax + 0x4], 0x8);     /* test byte [eax+0x4], 0x8 */
            ii(0x1016_8e3c, 2); if(jzd(0x1016_8e48, 0xa)) goto l_0x1016_8e48; /* jz 0x10168e48 */
            ii(0x1016_8e3e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_8e43, 5); jmpd(0x1016_95a8, 0x760); goto l_0x1016_95a8; /* jmp 0x101695a8 */
        l_0x1016_8e48:
            ii(0x1016_8e48, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_8e4a, 2); if(jzd(0x1016_8e8f, 0x43)) goto l_0x1016_8e8f; /* jz 0x10168e8f */
            ii(0x1016_8e4c, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_8e4e, 3); lea(esi, ebp + 0x8);                    /* lea esi, [ebp+0x8] */
            ii(0x1016_8e51, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e52, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e53, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e54, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e55, 3); mov(ebx, memd_a32[ss, esp]);            /* mov ebx, [esp] */
            ii(0x1016_8e58, 3); add(ebx, memd_a32[ds, eax + 0x8]);      /* add ebx, [eax+0x8] */
            ii(0x1016_8e5b, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8e5f, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1016_8e62, 4); mov(ecx, memd_a32[ss, esp + 0x4]);      /* mov ecx, [esp+0x4] */
            ii(0x1016_8e66, 3); add(ecx, memd_a32[ds, eax + 0xc]);      /* add ecx, [eax+0xc] */
            ii(0x1016_8e69, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8e6d, 4); mov(memd_a32[ss, esp + 0x4], ecx);      /* mov [esp+0x4], ecx */
            ii(0x1016_8e71, 4); mov(esi, memd_a32[ss, esp + 0x8]);      /* mov esi, [esp+0x8] */
            ii(0x1016_8e75, 3); add(esi, memd_a32[ds, eax + 0x8]);      /* add esi, [eax+0x8] */
            ii(0x1016_8e78, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8e7c, 4); mov(memd_a32[ss, esp + 0x8], esi);      /* mov [esp+0x8], esi */
            ii(0x1016_8e80, 4); mov(edi, memd_a32[ss, esp + 0xc]);      /* mov edi, [esp+0xc] */
            ii(0x1016_8e84, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1016_8e87, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1016_8e89, 4); mov(memd_a32[ss, esp + 0xc], edi);      /* mov [esp+0xc], edi */
            ii(0x1016_8e8d, 2); jmpd(0x1016_8ed7, 0x48); goto l_0x1016_8ed7; /* jmp 0x10168ed7 */
        l_0x1016_8e8f:
            ii(0x1016_8e8f, 3); mov(ebx, memd_a32[ds, eax + 0x38]);     /* mov ebx, [eax+0x38] */
            ii(0x1016_8e92, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_8e94, 2); if(jzd(0x1016_8ed7, 0x41)) goto l_0x1016_8ed7; /* jz 0x10168ed7 */
            ii(0x1016_8e96, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_8e98, 3); lea(esi, ebx + 0x8);                    /* lea esi, [ebx+0x8] */
            ii(0x1016_8e9b, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e9c, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e9d, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e9e, 1); movsd_a32();                            /* movsd */
            ii(0x1016_8e9f, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1016_8ea2, 3); add(ecx, memd_a32[ds, eax + 0x8]);      /* add ecx, [eax+0x8] */
            ii(0x1016_8ea5, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8ea9, 3); mov(memd_a32[ss, esp], ecx);            /* mov [esp], ecx */
            ii(0x1016_8eac, 4); mov(esi, memd_a32[ss, esp + 0x4]);      /* mov esi, [esp+0x4] */
            ii(0x1016_8eb0, 3); add(esi, memd_a32[ds, eax + 0xc]);      /* add esi, [eax+0xc] */
            ii(0x1016_8eb3, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8eb7, 4); mov(memd_a32[ss, esp + 0x4], esi);      /* mov [esp+0x4], esi */
            ii(0x1016_8ebb, 4); mov(edi, memd_a32[ss, esp + 0x8]);      /* mov edi, [esp+0x8] */
            ii(0x1016_8ebf, 3); add(edi, memd_a32[ds, eax + 0x8]);      /* add edi, [eax+0x8] */
            ii(0x1016_8ec2, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8ec6, 4); mov(memd_a32[ss, esp + 0x8], edi);      /* mov [esp+0x8], edi */
            ii(0x1016_8eca, 4); mov(edx, memd_a32[ss, esp + 0xc]);      /* mov edx, [esp+0xc] */
            ii(0x1016_8ece, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1016_8ed1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_8ed3, 4); mov(memd_a32[ss, esp + 0xc], edx);      /* mov [esp+0xc], edx */
        l_0x1016_8ed7:
            ii(0x1016_8ed7, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_8edb, 4); mov(ecx, memd_a32[ss, esp + 0x20]);     /* mov ecx, [esp+0x20] */
            ii(0x1016_8edf, 4); mov(ebx, memd_a32[ss, esp + 0x20]);     /* mov ebx, [esp+0x20] */
            ii(0x1016_8ee3, 4); mov(edx, memd_a32[ss, esp + 0x20]);     /* mov edx, [esp+0x20] */
            ii(0x1016_8ee7, 6); mov(memd_a32[ds, eax], 0xffff_ffff);    /* mov dword [eax], 0xffffffff */
            ii(0x1016_8eed, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8ef1, 3); mov(ecx, memd_a32[ds, ecx + 0x14]);     /* mov ecx, [ecx+0x14] */
            ii(0x1016_8ef4, 3); mov(ebx, memd_a32[ds, ebx + 0x10]);     /* mov ebx, [ebx+0x10] */
            ii(0x1016_8ef7, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x1016_8efa, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1016_8efd, 5); calld(/* sys */ 0x1016_c1f0, 0x32ee);   /* call 0x1016c1f0 */
            ii(0x1016_8f02, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8f04, 6); if(jnzd(0x1016_8fa9, 0x9f)) goto l_0x1016_8fa9; /* jnz 0x10168fa9 */
            ii(0x1016_8f0a, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_8f0c, 2); if(jzd(0x1016_8f55, 0x47)) goto l_0x1016_8f55; /* jz 0x10168f55 */
            ii(0x1016_8f0e, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_8f12, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1016_8f15, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_8f17, 4); test(memb_a32[ss, ebp + 0x4], 0x1);     /* test byte [ebp+0x4], 0x1 */
            ii(0x1016_8f1b, 2); if(jzd(0x1016_8f35, 0x18)) goto l_0x1016_8f35; /* jz 0x10168f35 */
            ii(0x1016_8f1d, 4); test(memb_a32[ss, ebp + 0x6], 0x2);     /* test byte [ebp+0x6], 0x2 */
            ii(0x1016_8f21, 2); if(jzd(0x1016_8f35, 0x12)) goto l_0x1016_8f35; /* jz 0x10168f35 */
            ii(0x1016_8f23, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_8f25, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_8f2a, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_8f2e, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_8f30, 3); mov(ebx, memd_a32[ss, ebp + 0x34]);     /* mov ebx, [ebp+0x34] */
            ii(0x1016_8f33, 2); jmpd(0x1016_8f45, 0x10); goto l_0x1016_8f45; /* jmp 0x10168f45 */
        l_0x1016_8f35:
            ii(0x1016_8f35, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_8f37, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_8f3c, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_8f40, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_8f42, 3); mov(ebx, memd_a32[ss, ebp + 0x30]);     /* mov ebx, [ebp+0x30] */
        l_0x1016_8f45:
            ii(0x1016_8f45, 5); calld(/* sys */ 0x1016_9b90, 0xc46);    /* call 0x10169b90 */
            ii(0x1016_8f4a, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8f4e, 7); mov(memd_a32[ds, eax + 0x34], 0);       /* mov dword [eax+0x34], 0x0 */
        l_0x1016_8f55:
            ii(0x1016_8f55, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_8f59, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1016_8f5b, 3); cmp(ecx, -0x1 /* 0xff */);              /* cmp ecx, 0xffffffff */
            ii(0x1016_8f5e, 2); if(jnzd(0x1016_8f6b, 0xb)) goto l_0x1016_8f6b; /* jnz 0x10168f6b */
            ii(0x1016_8f60, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_8f62, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_8f65, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_8f66, 1); popd(edi);                              /* pop edi */
            ii(0x1016_8f67, 1); popd(esi);                              /* pop esi */
            ii(0x1016_8f68, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_8f69, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_8f6a, 1); retd(); return;                         /* ret */
        l_0x1016_8f6b:
            ii(0x1016_8f6b, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8f6f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_8f71, 3); mov(dh, memb_a32[ss, ebp + 0x4]);       /* mov dh, [ebp+0x4] */
            ii(0x1016_8f74, 5); mov(memd_a32[ds, 0x101b_dde0], eax);    /* mov [0x101bdde0], eax */
            ii(0x1016_8f79, 3); test(dh, 0x8);                          /* test dh, 0x8 */
            ii(0x1016_8f7c, 2); if(jnzd(0x1016_8f94, 0x16)) goto l_0x1016_8f94; /* jnz 0x10168f94 */
            ii(0x1016_8f7e, 4); cmp(memd_a32[ss, ebp + 0x54], 0);       /* cmp dword [ebp+0x54], 0x0 */
            ii(0x1016_8f82, 6); if(jzd(0x1016_95a6, 0x61e)) goto l_0x1016_95a6; /* jz 0x101695a6 */
            ii(0x1016_8f88, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_8f8c, 3); mov(eax, memd_a32[ss, ebp + 0]);        /* mov eax, [ebp] */
            ii(0x1016_8f8f, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1016_8f91, 3); calld_abs(memd_a32[ss, ebp + 0x54]);    /* call dword [ebp+0x54] */
        l_0x1016_8f94:
            ii(0x1016_8f94, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_8f98, 6); mov(memd_a32[ds, eax], 0xffff_ffff);    /* mov dword [eax], 0xffffffff */
            ii(0x1016_8f9e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_8fa0, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_8fa3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_8fa4, 1); popd(edi);                              /* pop edi */
            ii(0x1016_8fa5, 1); popd(esi);                              /* pop esi */
            ii(0x1016_8fa6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_8fa7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_8fa8, 1); retd(); return;                         /* ret */
        l_0x1016_8fa9:
            ii(0x1016_8fa9, 4); mov(edx, memd_a32[ss, esp + 0x20]);     /* mov edx, [esp+0x20] */
            ii(0x1016_8fad, 5); calld(/* sys */ 0x1016_c348, 0x3396);   /* call 0x1016c348 */
            ii(0x1016_8fb2, 3); mov(bl, memb_a32[ds, edx + 0x4]);       /* mov bl, [edx+0x4] */
            ii(0x1016_8fb5, 4); mov(memd_a32[ss, esp + 0x18], eax);     /* mov [esp+0x18], eax */
            ii(0x1016_8fb9, 3); test(bl, 0x40);                         /* test bl, 0x40 */
            ii(0x1016_8fbc, 2); if(jnzd(0x1016_8fcb, 0xd)) goto l_0x1016_8fcb; /* jnz 0x10168fcb */
            ii(0x1016_8fbe, 2); test(al, 0x1);                          /* test al, 0x1 */
            ii(0x1016_8fc0, 2); if(jzd(0x1016_8fcb, 0x9)) goto l_0x1016_8fcb; /* jz 0x10168fcb */
            ii(0x1016_8fc2, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1016_8fc4, 5); calld(/* sys */ 0x1016_72d4, -0x1cf5);  /* call 0x101672d4 */
            ii(0x1016_8fc9, 2); jmpd(0x1016_8fdd, 0x12); goto l_0x1016_8fdd; /* jmp 0x10168fdd */
        l_0x1016_8fcb:
            ii(0x1016_8fcb, 5); cmp(memd_a32[ss, esp + 0x18], 0);       /* cmp dword [esp+0x18], 0x0 */
            ii(0x1016_8fd0, 2); if(jnzd(0x1016_8fdd, 0xb)) goto l_0x1016_8fdd; /* jnz 0x10168fdd */
            ii(0x1016_8fd2, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8fd6, 7); mov(memd_a32[ds, eax + 0x38], 0);       /* mov dword [eax+0x38], 0x0 */
        l_0x1016_8fdd:
            ii(0x1016_8fdd, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_8fdf, 6); if(jzd(0x1016_90fb, 0x116)) goto l_0x1016_90fb; /* jz 0x101690fb */
            ii(0x1016_8fe5, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_8fe7, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_8fe9, 5); calld(/* sys */ 0x1016_95b4, 0x5c6);    /* call 0x101695b4 */
            ii(0x1016_8fee, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8ff0, 6); if(jnzd(0x1016_907f, 0x89)) goto l_0x1016_907f; /* jnz 0x1016907f */
            ii(0x1016_8ff6, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_8ffa, 2); if(jnzd(0x1016_9005, 0x9)) goto l_0x1016_9005; /* jnz 0x10169005 */
            ii(0x1016_8ffc, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9000, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1016_9003, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
        l_0x1016_9005:
            ii(0x1016_9005, 4); test(memb_a32[ss, ebp + 0x4], 0x1);     /* test byte [ebp+0x4], 0x1 */
            ii(0x1016_9009, 2); if(jzd(0x1016_9023, 0x18)) goto l_0x1016_9023; /* jz 0x10169023 */
            ii(0x1016_900b, 4); test(memb_a32[ss, ebp + 0x6], 0x2);     /* test byte [ebp+0x6], 0x2 */
            ii(0x1016_900f, 2); if(jzd(0x1016_9023, 0x12)) goto l_0x1016_9023; /* jz 0x10169023 */
            ii(0x1016_9011, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9013, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9018, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_901c, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_901e, 3); mov(ebx, memd_a32[ss, ebp + 0x34]);     /* mov ebx, [ebp+0x34] */
            ii(0x1016_9021, 2); jmpd(0x1016_9033, 0x10); goto l_0x1016_9033; /* jmp 0x10169033 */
        l_0x1016_9023:
            ii(0x1016_9023, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9025, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_902a, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_902e, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_9030, 3); mov(ebx, memd_a32[ss, ebp + 0x30]);     /* mov ebx, [ebp+0x30] */
        l_0x1016_9033:
            ii(0x1016_9033, 5); calld(/* sys */ 0x1016_9b90, 0xb58);    /* call 0x10169b90 */
            ii(0x1016_9038, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_903c, 7); mov(memd_a32[ds, eax + 0x34], 0);       /* mov dword [eax+0x34], 0x0 */
            ii(0x1016_9043, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_9045, 5); mov(memd_a32[ds, 0x101b_dde0], eax);    /* mov [0x101bdde0], eax */
            ii(0x1016_904a, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_904e, 6); if(jnzd(0x1016_95a6, 0x552)) goto l_0x1016_95a6; /* jnz 0x101695a6 */
            ii(0x1016_9054, 4); cmp(memd_a32[ss, ebp + 0x54], 0);       /* cmp dword [ebp+0x54], 0x0 */
            ii(0x1016_9058, 6); if(jzd(0x1016_95a6, 0x548)) goto l_0x1016_95a6; /* jz 0x101695a6 */
            ii(0x1016_905e, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9062, 3); mov(eax, memd_a32[ss, ebp + 0]);        /* mov eax, [ebp] */
            ii(0x1016_9065, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1016_9067, 3); calld_abs(memd_a32[ss, ebp + 0x54]);    /* call dword [ebp+0x54] */
            ii(0x1016_906a, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_906e, 6); mov(memd_a32[ds, eax], 0xffff_ffff);    /* mov dword [eax], 0xffffffff */
            ii(0x1016_9074, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_9076, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_9079, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_907a, 1); popd(edi);                              /* pop edi */
            ii(0x1016_907b, 1); popd(esi);                              /* pop esi */
            ii(0x1016_907c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_907d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_907e, 1); retd(); return;                         /* ret */
        l_0x1016_907f:
            ii(0x1016_907f, 4); mov(memd_a32[ss, esp + 0x10], ebp);     /* mov [esp+0x10], ebp */
        l_0x1016_9083:
            ii(0x1016_9083, 6); mov(ecx, memd_a32[ds, 0x101b_dde0]);    /* mov ecx, [0x101bdde0] */
            ii(0x1016_9089, 3); cmp(ecx, -0x1 /* 0xff */);              /* cmp ecx, 0xffffffff */
            ii(0x1016_908c, 6); if(jzd(0x1016_91fc, 0x16a)) goto l_0x1016_91fc; /* jz 0x101691fc */
            ii(0x1016_9092, 4); mov(edx, memd_a32[ss, esp + 0x20]);     /* mov edx, [esp+0x20] */
            ii(0x1016_9096, 2); cmp(ecx, memd_a32[ds, edx]);            /* cmp ecx, [edx] */
            ii(0x1016_9098, 6); if(jzd(0x1016_91fc, 0x15e)) goto l_0x1016_91fc; /* jz 0x101691fc */
            ii(0x1016_909e, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_90a0, 5); calld(/* sys */ 0x1016_7dac, -0x12f9);  /* call 0x10167dac */
            ii(0x1016_90a5, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_90a7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_90a9, 6); if(jzd(0x1016_91fc, 0x14d)) goto l_0x1016_91fc; /* jz 0x101691fc */
            ii(0x1016_90af, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1016_90b4, 3); mov(ebp, memd_a32[ds, eax + 0x34]);     /* mov ebp, [eax+0x34] */
            ii(0x1016_90b7, 6); mov(memd_a32[ds, 0x101b_dde0], edi);    /* mov [0x101bdde0], edi */
            ii(0x1016_90bd, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_90bf, 6); if(jzd(0x1016_91fc, 0x137)) goto l_0x1016_91fc; /* jz 0x101691fc */
            ii(0x1016_90c5, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_90c9, 2); if(jnzd(0x1016_90d4, 0x9)) goto l_0x1016_90d4; /* jnz 0x101690d4 */
            ii(0x1016_90cb, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_90cf, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1016_90d2, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
        l_0x1016_90d4:
            ii(0x1016_90d4, 4); test(memb_a32[ss, ebp + 0x4], 0x1);     /* test byte [ebp+0x4], 0x1 */
            ii(0x1016_90d8, 6); if(jzd(0x1016_91a6, 0xc8)) goto l_0x1016_91a6; /* jz 0x101691a6 */
            ii(0x1016_90de, 4); test(memb_a32[ss, ebp + 0x6], 0x2);     /* test byte [ebp+0x6], 0x2 */
            ii(0x1016_90e2, 6); if(jzd(0x1016_91a6, 0xbe)) goto l_0x1016_91a6; /* jz 0x101691a6 */
            ii(0x1016_90e8, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_90ea, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_90ef, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_90f1, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_90f3, 3); mov(ebx, memd_a32[ss, ebp + 0x34]);     /* mov ebx, [ebp+0x34] */
            ii(0x1016_90f6, 5); jmpd(0x1016_91b4, 0xb9); goto l_0x1016_91b4; /* jmp 0x101691b4 */
        l_0x1016_90fb:
            ii(0x1016_90fb, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_90ff, 3); mov(edx, memd_a32[ds, eax + 0x38]);     /* mov edx, [eax+0x38] */
            ii(0x1016_9102, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_9104, 6); if(jzd(0x1016_9083, -0x87)) goto l_0x1016_9083; /* jz 0x10169083 */
            ii(0x1016_910a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_910c, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_910e, 5); calld(/* sys */ 0x1016_95b4, 0x4a1);    /* call 0x101695b4 */
            ii(0x1016_9113, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9115, 6); if(jzd(0x1016_9083, -0x98)) goto l_0x1016_9083; /* jz 0x10169083 */
            ii(0x1016_911b, 4); mov(esi, memd_a32[ss, esp + 0x20]);     /* mov esi, [esp+0x20] */
            ii(0x1016_911f, 3); mov(esi, memd_a32[ds, esi + 0x38]);     /* mov esi, [esi+0x38] */
            ii(0x1016_9122, 4); test(memb_a32[ds, esi + 0x4], 0x8);     /* test byte [esi+0x4], 0x8 */
            ii(0x1016_9126, 2); if(jnzd(0x1016_9131, 0x9)) goto l_0x1016_9131; /* jnz 0x10169131 */
            ii(0x1016_9128, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_912c, 3); mov(eax, memd_a32[ds, esi + 0x18]);     /* mov eax, [esi+0x18] */
            ii(0x1016_912f, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
        l_0x1016_9131:
            ii(0x1016_9131, 4); test(memb_a32[ds, esi + 0x4], 0x1);     /* test byte [esi+0x4], 0x1 */
            ii(0x1016_9135, 2); if(jzd(0x1016_914f, 0x18)) goto l_0x1016_914f; /* jz 0x1016914f */
            ii(0x1016_9137, 4); test(memb_a32[ds, esi + 0x6], 0x2);     /* test byte [esi+0x6], 0x2 */
            ii(0x1016_913b, 2); if(jzd(0x1016_914f, 0x12)) goto l_0x1016_914f; /* jz 0x1016914f */
            ii(0x1016_913d, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_913f, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9144, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_9148, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_914a, 3); mov(ebx, memd_a32[ds, esi + 0x34]);     /* mov ebx, [esi+0x34] */
            ii(0x1016_914d, 2); jmpd(0x1016_915f, 0x10); goto l_0x1016_915f; /* jmp 0x1016915f */
        l_0x1016_914f:
            ii(0x1016_914f, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9151, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9156, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_915a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_915c, 3); mov(ebx, memd_a32[ds, esi + 0x30]);     /* mov ebx, [esi+0x30] */
        l_0x1016_915f:
            ii(0x1016_915f, 5); calld(/* sys */ 0x1016_9b90, 0xa2c);    /* call 0x10169b90 */
            ii(0x1016_9164, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_9168, 3); mov(memd_a32[ds, eax + 0x34], esi);     /* mov [eax+0x34], esi */
            ii(0x1016_916b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_916d, 5); mov(memd_a32[ds, 0x101b_dde0], eax);    /* mov [0x101bdde0], eax */
            ii(0x1016_9172, 4); test(memb_a32[ds, esi + 0x4], 0x8);     /* test byte [esi+0x4], 0x8 */
            ii(0x1016_9176, 6); if(jnzd(0x1016_95a6, 0x42a)) goto l_0x1016_95a6; /* jnz 0x101695a6 */
            ii(0x1016_917c, 4); cmp(memd_a32[ds, esi + 0x50], 0);       /* cmp dword [esi+0x50], 0x0 */
            ii(0x1016_9180, 6); if(jzd(0x1016_95a6, 0x420)) goto l_0x1016_95a6; /* jz 0x101695a6 */
            ii(0x1016_9186, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_918a, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1016_918c, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1016_918e, 3); calld_abs(memd_a32[ds, esi + 0x50]);    /* call dword [esi+0x50] */
            ii(0x1016_9191, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_9195, 6); mov(memd_a32[ds, eax], 0xffff_ffff);    /* mov dword [eax], 0xffffffff */
            ii(0x1016_919b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_919d, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_91a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_91a1, 1); popd(edi);                              /* pop edi */
            ii(0x1016_91a2, 1); popd(esi);                              /* pop esi */
            ii(0x1016_91a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_91a4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_91a5, 1); retd(); return;                         /* ret */
        l_0x1016_91a6:
            ii(0x1016_91a6, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_91a8, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_91ad, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_91af, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_91b1, 3); mov(ebx, memd_a32[ss, ebp + 0x30]);     /* mov ebx, [ebp+0x30] */
        l_0x1016_91b4:
            ii(0x1016_91b4, 5); calld(/* sys */ 0x1016_9b90, 0x9d7);    /* call 0x10169b90 */
            ii(0x1016_91b9, 7); mov(memd_a32[ds, esi + 0x34], 0);       /* mov dword [esi+0x34], 0x0 */
            ii(0x1016_91c0, 7); mov(memd_a32[ds, esi + 0x38], 0);       /* mov dword [esi+0x38], 0x0 */
            ii(0x1016_91c7, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_91cb, 6); if(jnzd(0x1016_95a6, 0x3d5)) goto l_0x1016_95a6; /* jnz 0x101695a6 */
            ii(0x1016_91d1, 4); cmp(memd_a32[ss, ebp + 0x54], 0);       /* cmp dword [ebp+0x54], 0x0 */
            ii(0x1016_91d5, 6); if(jzd(0x1016_95a6, 0x3cb)) goto l_0x1016_95a6; /* jz 0x101695a6 */
            ii(0x1016_91db, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_91df, 3); mov(eax, memd_a32[ss, ebp + 0]);        /* mov eax, [ebp] */
            ii(0x1016_91e2, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1016_91e4, 3); calld_abs(memd_a32[ss, ebp + 0x54]);    /* call dword [ebp+0x54] */
            ii(0x1016_91e7, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_91eb, 6); mov(memd_a32[ds, eax], 0xffff_ffff);    /* mov dword [eax], 0xffffffff */
            ii(0x1016_91f1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_91f3, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_91f6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_91f7, 1); popd(edi);                              /* pop edi */
            ii(0x1016_91f8, 1); popd(esi);                              /* pop esi */
            ii(0x1016_91f9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_91fa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_91fb, 1); retd(); return;                         /* ret */
        l_0x1016_91fc:
            ii(0x1016_91fc, 4); mov(ebp, memd_a32[ss, esp + 0x10]);     /* mov ebp, [esp+0x10] */
            ii(0x1016_9200, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_9202, 6); if(jzd(0x1016_9520, 0x318)) goto l_0x1016_9520; /* jz 0x10169520 */
        l_0x1016_9208:
            ii(0x1016_9208, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_920c, 6); if(jnzd(0x1016_9515, 0x303)) goto l_0x1016_9515; /* jnz 0x10169515 */
            ii(0x1016_9212, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_9214, 3); lea(esi, ebp + 0x8);                    /* lea esi, [ebp+0x8] */
            ii(0x1016_9217, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9218, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9219, 1); movsd_a32();                            /* movsd */
            ii(0x1016_921a, 1); movsd_a32();                            /* movsd */
            ii(0x1016_921b, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_921f, 3); mov(edi, memd_a32[ss, esp]);            /* mov edi, [esp] */
            ii(0x1016_9222, 3); add(edi, memd_a32[ds, eax + 0x8]);      /* add edi, [eax+0x8] */
            ii(0x1016_9225, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_9229, 3); mov(memd_a32[ss, esp], edi);            /* mov [esp], edi */
            ii(0x1016_922c, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_9230, 3); add(edx, memd_a32[ds, eax + 0xc]);      /* add edx, [eax+0xc] */
            ii(0x1016_9233, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_9237, 4); mov(memd_a32[ss, esp + 0x4], edx);      /* mov [esp+0x4], edx */
            ii(0x1016_923b, 4); mov(ebx, memd_a32[ss, esp + 0x8]);      /* mov ebx, [esp+0x8] */
            ii(0x1016_923f, 3); add(ebx, memd_a32[ds, eax + 0x8]);      /* add ebx, [eax+0x8] */
            ii(0x1016_9242, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_9246, 4); mov(memd_a32[ss, esp + 0x8], ebx);      /* mov [esp+0x8], ebx */
            ii(0x1016_924a, 4); mov(ecx, memd_a32[ss, esp + 0xc]);      /* mov ecx, [esp+0xc] */
            ii(0x1016_924e, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1016_9251, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_9253, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_9255, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_9257, 4); mov(memd_a32[ss, esp + 0xc], ecx);      /* mov [esp+0xc], ecx */
            ii(0x1016_925b, 5); calld(/* sys */ 0x1016_95b4, 0x354);    /* call 0x101695b4 */
            ii(0x1016_9260, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9262, 6); if(jzd(0x1016_9515, 0x2ad)) goto l_0x1016_9515; /* jz 0x10169515 */
            ii(0x1016_9268, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_926c, 6); if(jnzd(0x1016_94d0, 0x25e)) goto l_0x1016_94d0; /* jnz 0x101694d0 */
            ii(0x1016_9272, 4); mov(cl, memb_a32[ss, esp + 0x18]);      /* mov cl, [esp+0x18] */
            ii(0x1016_9276, 3); test(cl, 0x3);                          /* test cl, 0x3 */
            ii(0x1016_9279, 6); if(jzd(0x1016_9399, 0x11a)) goto l_0x1016_9399; /* jz 0x10169399 */
            ii(0x1016_927f, 3); test(cl, 0x2);                          /* test cl, 0x2 */
            ii(0x1016_9282, 2); if(jzd(0x1016_9291, 0xd)) goto l_0x1016_9291; /* jz 0x10169291 */
            ii(0x1016_9284, 4); test(memb_a32[ss, ebp + 0x6], 0x8);     /* test byte [ebp+0x6], 0x8 */
            ii(0x1016_9288, 2); if(jnzd(0x1016_9291, 0x7)) goto l_0x1016_9291; /* jnz 0x10169291 */
            ii(0x1016_928a, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1016_928c, 5); jmpd(0x1016_9520, 0x28f); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_9291:
            ii(0x1016_9291, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_9295, 3); cmp(ebp, memd_a32[ds, eax + 0x34]);     /* cmp ebp, [eax+0x34] */
            ii(0x1016_9298, 2); if(jzd(0x1016_92a3, 0x9)) goto l_0x1016_92a3; /* jz 0x101692a3 */
            ii(0x1016_929a, 3); cmp(ebp, memd_a32[ds, eax + 0x38]);     /* cmp ebp, [eax+0x38] */
            ii(0x1016_929d, 6); if(jnzd(0x1016_9520, 0x27d)) goto l_0x1016_9520; /* jnz 0x10169520 */
        l_0x1016_92a3:
            ii(0x1016_92a3, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_92a7, 3); mov(memd_a32[ds, eax + 0x34], ebp);     /* mov [eax+0x34], ebp */
            ii(0x1016_92aa, 3); mov(memd_a32[ds, eax + 0x38], ebp);     /* mov [eax+0x38], ebp */
            ii(0x1016_92ad, 3); mov(bh, memb_a32[ss, ebp + 0x4]);       /* mov bh, [ebp+0x4] */
            ii(0x1016_92b0, 3); test(bh, 0x1);                          /* test bh, 0x1 */
            ii(0x1016_92b3, 6); if(jzd(0x1016_9347, 0x8e)) goto l_0x1016_9347; /* jz 0x10169347 */
            ii(0x1016_92b9, 3); test(bh, 0x2);                          /* test bh, 0x2 */
            ii(0x1016_92bc, 6); if(jzd(0x1016_937f, 0xbd)) goto l_0x1016_937f; /* jz 0x1016937f */
            ii(0x1016_92c2, 4); test(memb_a32[ss, ebp + 0x6], 0x2);     /* test byte [ebp+0x6], 0x2 */
            ii(0x1016_92c6, 2); if(jzd(0x1016_9309, 0x41)) goto l_0x1016_9309; /* jz 0x10169309 */
            ii(0x1016_92c8, 3); test(bh, 0x4);                          /* test bh, 0x4 */
            ii(0x1016_92cb, 6); if(jnzd(0x1016_937f, 0xae)) goto l_0x1016_937f; /* jnz 0x1016937f */
            ii(0x1016_92d1, 3); mov(ecx, memd_a32[ss, ebp + 0x68]);     /* mov ecx, [ebp+0x68] */
            ii(0x1016_92d4, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_92d6, 2); if(jzd(0x1016_92db, 0x3)) goto l_0x1016_92db; /* jz 0x101692db */
            ii(0x1016_92d8, 3); dec(memd_a32[ds, ecx + 0x4]);           /* dec dword [ecx+0x4] */
        l_0x1016_92db:
            ii(0x1016_92db, 5); test(memb_a32[ss, esp + 0x18], 0x1);    /* test byte [esp+0x18], 0x1 */
            ii(0x1016_92e0, 2); if(jzd(0x1016_92f0, 0xe)) goto l_0x1016_92f0; /* jz 0x101692f0 */
            ii(0x1016_92e2, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_92e6, 3); mov(eax, memd_a32[ss, ebp + 0x24]);     /* mov eax, [ebp+0x24] */
            ii(0x1016_92e9, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_92eb, 3); mov(eax, memd_a32[ss, ebp + 0x5c]);     /* mov eax, [ebp+0x5c] */
            ii(0x1016_92ee, 2); jmpd(0x1016_92fc, 0xc); goto l_0x1016_92fc; /* jmp 0x101692fc */
        l_0x1016_92f0:
            ii(0x1016_92f0, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_92f4, 3); mov(eax, memd_a32[ss, ebp + 0x2c]);     /* mov eax, [ebp+0x2c] */
            ii(0x1016_92f7, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_92f9, 3); mov(eax, memd_a32[ss, ebp + 0x64]);     /* mov eax, [ebp+0x64] */
        l_0x1016_92fc:
            ii(0x1016_92fc, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
            ii(0x1016_9300, 4); and(memb_a32[ss, ebp + 0x6], -0x3 /* 0xfd */); /* and byte [ebp+0x6], 0xfd */
            ii(0x1016_9304, 5); jmpd(0x1016_937f, 0x76); goto l_0x1016_937f; /* jmp 0x1016937f */
        l_0x1016_9309:
            ii(0x1016_9309, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_930b, 5); calld(/* sys */ 0x1016_9ad0, 0x7c0);    /* call 0x10169ad0 */
            ii(0x1016_9310, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_9313, 2); if(jnzd(0x1016_931c, 0x7)) goto l_0x1016_931c; /* jnz 0x1016931c */
            ii(0x1016_9315, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1016_9317, 5); jmpd(0x1016_9520, 0x204); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_931c:
            ii(0x1016_931c, 5); test(memb_a32[ss, esp + 0x18], 0x1);    /* test byte [esp+0x18], 0x1 */
            ii(0x1016_9321, 2); if(jzd(0x1016_9331, 0xe)) goto l_0x1016_9331; /* jz 0x10169331 */
            ii(0x1016_9323, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9327, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
            ii(0x1016_932a, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_932c, 3); mov(eax, memd_a32[ss, ebp + 0x58]);     /* mov eax, [ebp+0x58] */
            ii(0x1016_932f, 2); jmpd(0x1016_933d, 0xc); goto l_0x1016_933d; /* jmp 0x1016933d */
        l_0x1016_9331:
            ii(0x1016_9331, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9335, 3); mov(eax, memd_a32[ss, ebp + 0x28]);     /* mov eax, [ebp+0x28] */
            ii(0x1016_9338, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_933a, 3); mov(eax, memd_a32[ss, ebp + 0x60]);     /* mov eax, [ebp+0x60] */
        l_0x1016_933d:
            ii(0x1016_933d, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
            ii(0x1016_9341, 4); or(memb_a32[ss, ebp + 0x6], 0x2);       /* or byte [ebp+0x6], 0x2 */
            ii(0x1016_9345, 2); jmpd(0x1016_937f, 0x38); goto l_0x1016_937f; /* jmp 0x1016937f */
        l_0x1016_9347:
            ii(0x1016_9347, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_9349, 5); calld(/* sys */ 0x1016_9ad0, 0x782);    /* call 0x10169ad0 */
            ii(0x1016_934e, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_9351, 2); if(jnzd(0x1016_935a, 0x7)) goto l_0x1016_935a; /* jnz 0x1016935a */
            ii(0x1016_9353, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1016_9355, 5); jmpd(0x1016_9520, 0x1c6); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_935a:
            ii(0x1016_935a, 5); test(memb_a32[ss, esp + 0x18], 0x1);    /* test byte [esp+0x18], 0x1 */
            ii(0x1016_935f, 2); if(jzd(0x1016_936f, 0xe)) goto l_0x1016_936f; /* jz 0x1016936f */
            ii(0x1016_9361, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9365, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
            ii(0x1016_9368, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_936a, 3); mov(eax, memd_a32[ss, ebp + 0x58]);     /* mov eax, [ebp+0x58] */
            ii(0x1016_936d, 2); jmpd(0x1016_937b, 0xc); goto l_0x1016_937b; /* jmp 0x1016937b */
        l_0x1016_936f:
            ii(0x1016_936f, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9373, 3); mov(eax, memd_a32[ss, ebp + 0x28]);     /* mov eax, [ebp+0x28] */
            ii(0x1016_9376, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_9378, 3); mov(eax, memd_a32[ss, ebp + 0x60]);     /* mov eax, [ebp+0x60] */
        l_0x1016_937b:
            ii(0x1016_937b, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
        l_0x1016_937f:
            ii(0x1016_937f, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9381, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9386, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_938a, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_938c, 3); mov(ebx, memd_a32[ss, ebp + 0x34]);     /* mov ebx, [ebp+0x34] */
            ii(0x1016_938f, 5); calld(/* sys */ 0x1016_9b90, 0x7fc);    /* call 0x10169b90 */
            ii(0x1016_9394, 5); jmpd(0x1016_9520, 0x187); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_9399:
            ii(0x1016_9399, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_939d, 3); mov(esi, memd_a32[ds, eax + 0x38]);     /* mov esi, [eax+0x38] */
            ii(0x1016_93a0, 2); cmp(ebp, esi);                          /* cmp ebp, esi */
            ii(0x1016_93a2, 6); if(jnzd(0x1016_94d0, 0x128)) goto l_0x1016_94d0; /* jnz 0x101694d0 */
            ii(0x1016_93a8, 3); test(cl, 0x30);                         /* test cl, 0x30 */
            ii(0x1016_93ab, 6); if(jzd(0x1016_94d0, 0x11f)) goto l_0x1016_94d0; /* jz 0x101694d0 */
            ii(0x1016_93b1, 7); mov(memd_a32[ds, eax + 0x38], 0);       /* mov dword [eax+0x38], 0x0 */
            ii(0x1016_93b8, 3); mov(memd_a32[ds, eax + 0x34], esi);     /* mov [eax+0x34], esi */
            ii(0x1016_93bb, 3); mov(ah, memb_a32[ds, esi + 0x4]);       /* mov ah, [esi+0x4] */
            ii(0x1016_93be, 3); test(ah, 0x1);                          /* test ah, 0x1 */
            ii(0x1016_93c1, 6); if(jzd(0x1016_9468, 0xa1)) goto l_0x1016_9468; /* jz 0x10169468 */
            ii(0x1016_93c7, 3); test(ah, 0x2);                          /* test ah, 0x2 */
            ii(0x1016_93ca, 6); if(jnzd(0x1016_949d, 0xcd)) goto l_0x1016_949d; /* jnz 0x1016949d */
            ii(0x1016_93d0, 4); test(memb_a32[ds, esi + 0x6], 0x2);     /* test byte [esi+0x6], 0x2 */
            ii(0x1016_93d4, 2); if(jzd(0x1016_9417, 0x41)) goto l_0x1016_9417; /* jz 0x10169417 */
            ii(0x1016_93d6, 3); test(ah, 0x4);                          /* test ah, 0x4 */
            ii(0x1016_93d9, 6); if(jnzd(0x1016_949d, 0xbe)) goto l_0x1016_949d; /* jnz 0x1016949d */
            ii(0x1016_93df, 3); mov(ecx, memd_a32[ds, esi + 0x68]);     /* mov ecx, [esi+0x68] */
            ii(0x1016_93e2, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_93e4, 2); if(jzd(0x1016_93e9, 0x3)) goto l_0x1016_93e9; /* jz 0x101693e9 */
            ii(0x1016_93e6, 3); dec(memd_a32[ds, ecx + 0x4]);           /* dec dword [ecx+0x4] */
        l_0x1016_93e9:
            ii(0x1016_93e9, 5); test(memb_a32[ss, esp + 0x18], 0x10);   /* test byte [esp+0x18], 0x10 */
            ii(0x1016_93ee, 2); if(jzd(0x1016_93fe, 0xe)) goto l_0x1016_93fe; /* jz 0x101693fe */
            ii(0x1016_93f0, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_93f4, 3); mov(eax, memd_a32[ss, ebp + 0x24]);     /* mov eax, [ebp+0x24] */
            ii(0x1016_93f7, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_93f9, 3); mov(eax, memd_a32[ss, ebp + 0x5c]);     /* mov eax, [ebp+0x5c] */
            ii(0x1016_93fc, 2); jmpd(0x1016_940a, 0xc); goto l_0x1016_940a; /* jmp 0x1016940a */
        l_0x1016_93fe:
            ii(0x1016_93fe, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9402, 3); mov(eax, memd_a32[ss, ebp + 0x2c]);     /* mov eax, [ebp+0x2c] */
            ii(0x1016_9405, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_9407, 3); mov(eax, memd_a32[ss, ebp + 0x64]);     /* mov eax, [ebp+0x64] */
        l_0x1016_940a:
            ii(0x1016_940a, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
            ii(0x1016_940e, 4); and(memb_a32[ss, ebp + 0x6], -0x3 /* 0xfd */); /* and byte [ebp+0x6], 0xfd */
            ii(0x1016_9412, 5); jmpd(0x1016_949d, 0x86); goto l_0x1016_949d; /* jmp 0x1016949d */
        l_0x1016_9417:
            ii(0x1016_9417, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9419, 5); calld(/* sys */ 0x1016_9ad0, 0x6b2);    /* call 0x10169ad0 */
            ii(0x1016_941e, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_9421, 2); if(jnzd(0x1016_943f, 0x1c)) goto l_0x1016_943f; /* jnz 0x1016943f */
            ii(0x1016_9423, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9425, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_942a, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_942e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9430, 3); mov(ebx, memd_a32[ds, esi + 0x30]);     /* mov ebx, [esi+0x30] */
            ii(0x1016_9433, 5); calld(/* sys */ 0x1016_9b90, 0x758);    /* call 0x10169b90 */
            ii(0x1016_9438, 2); xor(ebp, esi);                          /* xor ebp, esi */
            ii(0x1016_943a, 5); jmpd(0x1016_9520, 0xe1); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_943f:
            ii(0x1016_943f, 3); test(cl, 0x10);                         /* test cl, 0x10 */
            ii(0x1016_9442, 2); if(jzd(0x1016_9452, 0xe)) goto l_0x1016_9452; /* jz 0x10169452 */
            ii(0x1016_9444, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9448, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1016_944b, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_944d, 3); mov(eax, memd_a32[ds, esi + 0x58]);     /* mov eax, [esi+0x58] */
            ii(0x1016_9450, 2); jmpd(0x1016_945e, 0xc); goto l_0x1016_945e; /* jmp 0x1016945e */
        l_0x1016_9452:
            ii(0x1016_9452, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9456, 3); mov(eax, memd_a32[ds, esi + 0x28]);     /* mov eax, [esi+0x28] */
            ii(0x1016_9459, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_945b, 3); mov(eax, memd_a32[ds, esi + 0x60]);     /* mov eax, [esi+0x60] */
        l_0x1016_945e:
            ii(0x1016_945e, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
            ii(0x1016_9462, 4); or(memb_a32[ss, ebp + 0x6], 0x2);       /* or byte [ebp+0x6], 0x2 */
            ii(0x1016_9466, 2); jmpd(0x1016_949d, 0x35); goto l_0x1016_949d; /* jmp 0x1016949d */
        l_0x1016_9468:
            ii(0x1016_9468, 4); test(memb_a32[ds, esi + 0x6], 0x2);     /* test byte [esi+0x6], 0x2 */
            ii(0x1016_946c, 2); if(jzd(0x1016_9478, 0xa)) goto l_0x1016_9478; /* jz 0x10169478 */
            ii(0x1016_946e, 3); mov(edx, memd_a32[ds, esi + 0x68]);     /* mov edx, [esi+0x68] */
            ii(0x1016_9471, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_9473, 2); if(jzd(0x1016_9478, 0x3)) goto l_0x1016_9478; /* jz 0x10169478 */
            ii(0x1016_9475, 3); dec(memd_a32[ds, edx + 0x4]);           /* dec dword [edx+0x4] */
        l_0x1016_9478:
            ii(0x1016_9478, 5); test(memb_a32[ss, esp + 0x18], 0x10);   /* test byte [esp+0x18], 0x10 */
            ii(0x1016_947d, 2); if(jzd(0x1016_948d, 0xe)) goto l_0x1016_948d; /* jz 0x1016948d */
            ii(0x1016_947f, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9483, 3); mov(eax, memd_a32[ss, ebp + 0x24]);     /* mov eax, [ebp+0x24] */
            ii(0x1016_9486, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_9488, 3); mov(eax, memd_a32[ss, ebp + 0x5c]);     /* mov eax, [ebp+0x5c] */
            ii(0x1016_948b, 2); jmpd(0x1016_9499, 0xc); goto l_0x1016_9499; /* jmp 0x10169499 */
        l_0x1016_948d:
            ii(0x1016_948d, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9491, 3); mov(eax, memd_a32[ss, ebp + 0x2c]);     /* mov eax, [ebp+0x2c] */
            ii(0x1016_9494, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_9496, 3); mov(eax, memd_a32[ss, ebp + 0x64]);     /* mov eax, [ebp+0x64] */
        l_0x1016_9499:
            ii(0x1016_9499, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
        l_0x1016_949d:
            ii(0x1016_949d, 3); mov(edi, memd_a32[ss, ebp + 0x38]);     /* mov edi, [ebp+0x38] */
            ii(0x1016_94a0, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_94a2, 2); if(jzd(0x1016_94ba, 0x16)) goto l_0x1016_94ba; /* jz 0x101694ba */
            ii(0x1016_94a4, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_94a6, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_94ab, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_94af, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_94b1, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_94b3, 5); calld(/* sys */ 0x1016_9b90, 0x6d8);    /* call 0x10169b90 */
            ii(0x1016_94b8, 2); jmpd(0x1016_9520, 0x66); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_94ba:
            ii(0x1016_94ba, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_94bf, 4); mov(edx, memd_a32[ss, esp + 0x20]);     /* mov edx, [esp+0x20] */
            ii(0x1016_94c3, 1); pushd(edi);                             /* push edi */
            ii(0x1016_94c4, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_94c6, 3); mov(ebx, memd_a32[ss, ebp + 0x30]);     /* mov ebx, [ebp+0x30] */
            ii(0x1016_94c9, 5); calld(/* sys */ 0x1016_9b90, 0x6c2);    /* call 0x10169b90 */
            ii(0x1016_94ce, 2); jmpd(0x1016_9520, 0x50); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_94d0:
            ii(0x1016_94d0, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_94d4, 4); cmp(memd_a32[ds, eax + 0x34], 0);       /* cmp dword [eax+0x34], 0x0 */
            ii(0x1016_94d8, 2); if(jnzd(0x1016_9520, 0x46)) goto l_0x1016_9520; /* jnz 0x10169520 */
            ii(0x1016_94da, 5); cmp(memd_a32[ss, esp + 0x18], 0);       /* cmp dword [esp+0x18], 0x0 */
            ii(0x1016_94df, 2); if(jnzd(0x1016_9520, 0x3f)) goto l_0x1016_9520; /* jnz 0x10169520 */
            ii(0x1016_94e1, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_94e5, 3); mov(memd_a32[ds, eax + 0x34], ebp);     /* mov [eax+0x34], ebp */
            ii(0x1016_94e8, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_94ec, 2); if(jnzd(0x1016_94fe, 0x10)) goto l_0x1016_94fe; /* jnz 0x101694fe */
            ii(0x1016_94ee, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_94f2, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1016_94f5, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1016_94f7, 3); mov(eax, memd_a32[ss, ebp + 0x50]);     /* mov eax, [ebp+0x50] */
            ii(0x1016_94fa, 4); mov(memd_a32[ss, esp + 0x14], eax);     /* mov [esp+0x14], eax */
        l_0x1016_94fe:
            ii(0x1016_94fe, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9500, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9505, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_9509, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_950b, 3); mov(ebx, memd_a32[ss, ebp + 0x38]);     /* mov ebx, [ebp+0x38] */
            ii(0x1016_950e, 5); calld(/* sys */ 0x1016_9b90, 0x67d);    /* call 0x10169b90 */
            ii(0x1016_9513, 2); jmpd(0x1016_9520, 0xb); goto l_0x1016_9520; /* jmp 0x10169520 */
        l_0x1016_9515:
            ii(0x1016_9515, 3); mov(ebp, memd_a32[ss, ebp + 0x70]);     /* mov ebp, [ebp+0x70] */
            ii(0x1016_9518, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_951a, 6); if(jnzd(0x1016_9208, -0x318)) goto l_0x1016_9208; /* jnz 0x10169208 */
        l_0x1016_9520:
            ii(0x1016_9520, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_9522, 2); if(jnzd(0x1016_9545, 0x21)) goto l_0x1016_9545; /* jnz 0x10169545 */
            ii(0x1016_9524, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_9528, 4); test(memb_a32[ds, eax + 0x4], 0x80);    /* test byte [eax+0x4], 0x80 */
            ii(0x1016_952c, 2); if(jzd(0x1016_9579, 0x4b)) goto l_0x1016_9579; /* jz 0x10169579 */
            ii(0x1016_952e, 4); mov(dh, memb_a32[ss, esp + 0x18]);      /* mov dh, [esp+0x18] */
            ii(0x1016_9532, 3); test(dh, 0x3);                          /* test dh, 0x3 */
            ii(0x1016_9535, 2); if(jzd(0x1016_9579, 0x42)) goto l_0x1016_9579; /* jz 0x10169579 */
            ii(0x1016_9537, 3); test(dh, 0xc);                          /* test dh, 0xc */
            ii(0x1016_953a, 2); if(jnzd(0x1016_9579, 0x3d)) goto l_0x1016_9579; /* jnz 0x10169579 */
            ii(0x1016_953c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_953e, 5); calld(/* sys */ 0x1016_7b80, -0x19c3);  /* call 0x10167b80 */
            ii(0x1016_9543, 2); jmpd(0x1016_9579, 0x34); goto l_0x1016_9579; /* jmp 0x10169579 */
        l_0x1016_9545:
            ii(0x1016_9545, 4); test(memb_a32[ss, ebp + 0x4], 0x10);    /* test byte [ebp+0x4], 0x10 */
            ii(0x1016_9549, 2); if(jzd(0x1016_9579, 0x2e)) goto l_0x1016_9579; /* jz 0x10169579 */
            ii(0x1016_954b, 4); mov(ch, memb_a32[ss, esp + 0x18]);      /* mov ch, [esp+0x18] */
            ii(0x1016_954f, 3); test(ch, 0x3);                          /* test ch, 0x3 */
            ii(0x1016_9552, 2); if(jzd(0x1016_9579, 0x25)) goto l_0x1016_9579; /* jz 0x10169579 */
            ii(0x1016_9554, 3); test(ch, 0xc);                          /* test ch, 0xc */
            ii(0x1016_9557, 2); if(jnzd(0x1016_9579, 0x20)) goto l_0x1016_9579; /* jnz 0x10169579 */
            ii(0x1016_9559, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_955d, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9562, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_9564, 4); mov(edx, memd_a32[ss, esp + 0x20]);     /* mov edx, [esp+0x20] */
            ii(0x1016_9568, 5); calld(/* sys */ 0x1016_7b80, -0x19ed);  /* call 0x10167b80 */
            ii(0x1016_956d, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_956f, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_9571, 3); mov(ebx, memd_a32[ss, ebp + 0x30]);     /* mov ebx, [ebp+0x30] */
            ii(0x1016_9574, 5); calld(/* sys */ 0x1016_9b90, 0x617);    /* call 0x10169b90 */
        l_0x1016_9579:
            ii(0x1016_9579, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_957d, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_957f, 5); mov(memd_a32[ds, 0x101b_dde0], eax);    /* mov [0x101bdde0], eax */
            ii(0x1016_9584, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_9586, 2); if(jzd(0x1016_95a6, 0x1e)) goto l_0x1016_95a6; /* jz 0x101695a6 */
            ii(0x1016_9588, 5); cmp(memd_a32[ss, esp + 0x14], 0);       /* cmp dword [esp+0x14], 0x0 */
            ii(0x1016_958d, 2); if(jzd(0x1016_95a6, 0x17)) goto l_0x1016_95a6; /* jz 0x101695a6 */
            ii(0x1016_958f, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_9593, 3); mov(eax, memd_a32[ss, ebp + 0]);        /* mov eax, [ebp] */
            ii(0x1016_9596, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1016_9598, 4); calld_abs(memd_a32[ss, esp + 0x14]);    /* call dword [esp+0x14] */
            ii(0x1016_959c, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_95a0, 6); mov(memd_a32[ds, eax], 0xffff_ffff);    /* mov dword [eax], 0xffffffff */
        l_0x1016_95a6:
            ii(0x1016_95a6, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_95a8:
            ii(0x1016_95a8, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_95ab, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_95ac, 1); popd(edi);                              /* pop edi */
            ii(0x1016_95ad, 1); popd(esi);                              /* pop esi */
            ii(0x1016_95ae, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_95af, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_95b0, 1); retd(); return;                         /* ret */
        }
    }
}
